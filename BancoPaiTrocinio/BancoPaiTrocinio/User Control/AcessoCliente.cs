using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.Conexões;

namespace BancoPaiTrocinio.User_Control
{
    public partial class AcessoCliente : UserControl {

        private static ConexaoMySql conexao = new ConexaoMySql();
        private string radioText;
        public string strGelio;
        private int buscaOn;
        public Boolean jp;

        public AcessoCliente() {
            InitializeComponent();
        }

        public string Manipula_String(string s) {
            try {
                if (this.radioText == "Conta Corrente" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          LEFT JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          LEFT JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          LEFT JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id_conta_bancaria
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (this.radioText == "Conta Poupança" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          LEFT JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          LEFT JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          LEFT JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id_conta_bancaria
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (this.radioText == "Conta Corrente") {
                    s = "SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuario LEFT JOIN cliente c ON u.u_id_cliente = c.c_id_usuario LEFT JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente LEFT JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id_conta_bancaria;";
                } else if (this.radioText == "Conta Poupança") {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          LEFT JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          LEFT JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          LEFT JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id_conta_bancaria";
                }
            } catch (Exception e) {
                MessageBox.Show("Erro: " + e.Message);
            }
            if (buscaOn == 1) {
                buscaOn = 0;
            }
            return s;
        }

        private string ConfirmaBotao() {
            foreach (RadioButton r in Grp_TipoConta.Controls) {
                if (r.Checked == true) {
                    this.radioText = r.Text;
                }
            }
            return radioText;
        }

        private void AcessoCliente_Load(object sender, EventArgs e) {
            try {
                this.radioText = ConfirmaBotao();
                if (this.radioText != string.Empty) {
                    this.strGelio = Manipula_String(this.strGelio);
                    dataGridView2.DataSource = conexao.RetornaSQL(Convert.ToString(this.strGelio));
                } else {
                    MessageBox.Show("Por favor, selecione um tipo de conta.");
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Buscar_Click(object sender, EventArgs e) {
            if (TxtBusca.Text == string.Empty) {
                MessageBox.Show("Digite um CPF!");
            } else {
                buscaOn = 1;
                AcessoCliente_Load(sender, e);
            }
        }

        private void Atualizar_Click(object sender, EventArgs e) {
            AcessoCliente_Load(sender, e);
        }

        private void Inserir_Click(object sender, EventArgs e) {
           
            if (Txt_Nome.Text == string.Empty || Txt_Bairro.Text == string.Empty || Txt_Celular.Text == string.Empty || Txt_Cidade.Text == string.Empty || Txt_CPF.Text == string.Empty || Txt_Profissao.Text == string.Empty || Txt_Email.Text == string.Empty || Txt_CEP.Text == string.Empty || Txt_Logradouro.Text == string.Empty || Txt_Rg.Text == string.Empty || Txt_Saldo.Text == string.Empty || Txt_Telefone.Text == string.Empty || Txt_Complemento.Text == string.Empty || Txt_Estado.Text == string.Empty || Txt_NumeroAgencia.Text == string.Empty || Txt_NumeroConta.Text == string.Empty) {
                MessageBox.Show("É necessário preencher todos os campos!");
            } else {
                this.radioText = ConfirmaBotao();
                try {
                    try {
                        DataTable averigua = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(Txt_CPF.Text)}';");
                    } catch (Exception b) {
                        MessageBox.Show("Cliente não consta no sistema! Erro: " + b.Message);
                        return;
                    }
                    DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(Txt_CPF.Text)}';");
                    conexao.ExecutaSQL($"INSERT INTO cliente (c_id_usuario, c_profissao) VALUES ({Convert.ToInt32(query.Rows[0]["u_id"])},{Convert.ToString(Txt_Profissao.Text)});");
                    DataTable query2 = conexao.RetornaSQL($"SELECT c_id FROM cliente WHERE c_id_usuario = {query.Rows[0]["u_id"]};");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_id_cliente = {query2.Rows[0]["c_id"]} WHERE u_id = {Convert.ToInt32(query.Rows[0]["u_id"])};");
                    conexao.ExecutaSQL($"INSERT INTO conta_bancaria (cb_agencia, cb_id_cliente) VALUES ({Convert.ToInt64(Txt_NumeroAgencia.Text)},{Convert.ToInt32(query2.Rows[0]["c_id"])});");
                    DataTable query3 = conexao.RetornaSQL($"SELECT cb_id FROM conta_bancaria WHERE cb_id_cliente = {query2.Rows[0]["c_id"]};");
                    if (radioText == "Conta Corrente") {
                        conexao.ExecutaSQL($"INSERT INTO conta_corrente (cc_id_conta_bancaria,cc_nr_conta_corrente,cc_saldo) VALUES ({Convert.ToInt32(query3.Rows[0]["cb_id"])},{Convert.ToInt64(Txt_NumeroConta.Text)},{float.Parse(Txt_Saldo.Text)});");
                        DataTable query4 = conexao.RetornaSQL($"SELECT cc_id FROM conta_corrente WHERE cc_id_conta_bancaria = {Convert.ToInt32(query3.Rows[0]["cb_id"])};");
                        conexao.ExecutaSQL($"UPDATE conta_bancaria SET cb_id_conta_corrente = {Convert.ToInt32(query4.Rows[0]["cc_id"])} WHERE cb_id = {Convert.ToInt32(query3.Rows[0]["cb_id"])};");
                    } else if (radioText == "Conta Poupança") {
                        conexao.ExecutaSQL($"INSERT INTO conta_poupanca (cp_id_conta_bancaria, cp_nr_conta_poupanca, cp_valor) VALUES ({Convert.ToInt32(query3.Rows[0]["cb_id"])},{Convert.ToInt64(Txt_NumeroConta.Text)},{float.Parse(Txt_Saldo.Text)});");
                        DataTable query4 = conexao.RetornaSQL($"SELECT cp_id FROM conta_corrente WHERE cp_id_conta_bancaria = { Convert.ToInt32(query3.Rows[0]["cb_id"])}; ");
                        conexao.ExecutaSQL($"UPDATE conta_bancaria SET cb_id_conta_poupanca = {Convert.ToInt32(query4.Rows[0]["cp_id"])} WHERE cb_id = {Convert.ToInt32(query3.Rows[0]["cb_id"])};");
                    }
                } catch (Exception a) {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e) {
            DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf = {Convert.ToString(Txt_Excluir.Text)}");
            conexao.ExecutaSQL($"DELETE FROM usuario WHERE u_id = {query.Rows[0]["u_id"]};");
            AcessoCliente_Load(sender, e);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Txt_Nome.Text =;
            //Txt_CPF.Text =;
            //Txt_Rg.Text =;
            //Txt_CEP.Text =;
            //Txt_Logradouro.Text =;
            //Txt_Complemento.Text =;
            //Txt_Cidade.Text =;
            //Txt_Bairro.Text =;
            //Txt_Estado.Text =;
            //Txt_Telefone.Text =;
            //Txt_Celular.Text =;
        }
    }
}
