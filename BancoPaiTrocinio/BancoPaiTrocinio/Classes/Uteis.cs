using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using System.Windows.Forms;
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio {
    public class Cls_Uteis {
        Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
        public static bool ConsultaUserUsuario(string user) {
            Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
            try {
                DataTable db_user_login = connect.RetornaSQL($"SELECT u_usuario FROM usuario WHERE u_usuario = '{user}'");
                if ((string)db_user_login.Rows[0]["u_usuario"]==user) {
                    return true;
                } else {
                    MessageBox.Show("Usuário inválido!");
                    return false;
                }
            } catch (Exception e) {
                MessageBox.Show("Erro:"+e.Message);
            }
            return false;
        }

        public static bool ConsultaSenhaUsuario(string pass) {
            Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
            try {
                DataTable db_user_senha = connect.RetornaSQL($"SELECT u_senha FROM usuario WHERE u_senha = '{pass}'");
                if ((string)db_user_senha.Rows[0]["u_senha"] == pass) {
                    return true;
                } else {
                    MessageBox.Show("Senha inválida!");
                    return false;
                }
            } catch (Exception e) {
                MessageBox.Show("Erro:"+e.Message);
            }
            return false;
        }

        public static bool ValidaLogin(string senha, string login) {
            Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
            if (ConsultaUserUsuario(login) == true && ConsultaSenhaUsuario(senha) == true) {
                try {
                    DataTable db_login = connect.RetornaSQL($"SELECT u_senha,u_usuario FROM usuario WHERE u_senha = '{senha}' AND u_usuario = '{login}'");
                    if ((string)db_login.Rows[0]["u_senha"]==senha && (string)db_login.Rows[0]["u_usuario"]==login) {
                        return true;
                    } else {
                        MessageBox.Show("Conta inválida!");
                        return false;
                    }
                } catch (Exception e) {
                    MessageBox.Show(e.Message, "Banco Paitrocinio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                return false;
            }
            return false;
        }

        //public static bool ValidaSenhaLogin(string senha)
        //{
        //    if (senha == "curso")
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static string VerificaConta(string senha, string login) {
            Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
            try {
                DataTable query = connect.RetornaSQL($"SELECT cb.cb_id_conta_corrente, cb.cb_id_conta_poupanca FROM usuario u INNER JOIN cliente c ON u.u_id_cliente = c.c_id INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente WHERE u.u_usuario='{login}' AND u.u_senha='{senha}'");
                if (query.Rows[0]["cb_id_conta_poupanca"] is DBNull) {
                    return "Conta Corrente";
                } else if (query.Rows[0]["cb_id_conta_corrente"] is DBNull) {
                    return "Conta Poupança";
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "Banco Paitrocinio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return null;
            }
            return null;
        }

        public static bool ValidaFuncao(string senha, string login, string funcao) {
            Conexões.ConexaoMySql conexao = new Conexões.ConexaoMySql();
            try {
                DataTable query = conexao.RetornaSQL($"SELECT f.f_funcao FROM usuario u INNER JOIN funcionario f ON u.u_id = f.f_id_usuario WHERE u.u_senha='{senha}' AND u.u_usuario = '{login}'");
                if ((string)query.Rows[0]["f_funcao"]==funcao) {
                    return true;
                }
            }catch(Exception a) {
                MessageBox.Show("Este sim é um usuário gay!");
                return false;
            }
            return false;
        }

        public static string GeraJSONCEP(string CEP) {
            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();

        }
        public static bool Valida(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public class ChecaForcaSenha {

            public enum ForcaDaSenha {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha) {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha) {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha) {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha) {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha) {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha) {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha) {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete) {
                    return 30;
                } else {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha) {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }

        }
    }
}
