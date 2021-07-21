using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio
{
    public partial class CadastroCliente : UserControl
    {
        Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
        public CadastroCliente()
        {
            InitializeComponent();
            Grp_Cadastro.Text = "Cadastro";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Lbl_Celular.Text = "Celular";
            Lbl_Email.Text = "E-mail";
            Lbl_Rg.Text = "RG";
            Lbl_Usuario.Text = "Usuario";
            Lbl_Senha.Text = "Senha";
            Lbl_SenhaConfirmacao.Text = "Confirmar Senha";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_Profissao.Text = "Profissão";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");



            LimparFormulario();
        }

        private void LimparFormulario()
        {
            Txt_Usuario.Text = "";
            Txt_Senha.Text = "";
            Txt_SenhaConfirmacao.Text = "";
            Txt_Celular.Text = "";
            Txt_Rg.Text = "";
            Txt_Email.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_CPF.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Txt_CEP.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Complemento.Text = "";
            Txt_Cidade.Text = "";
            Txt_Bairro.Text = "";
            Txt_Telefone.Text = "";
            Txt_Profissao.Text = "";

        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        Cep.Unit cep = new Cep.Unit();
                        cep = Cep.DeserializedClassUnit(vJson);
                        Txt_Logradouro.Text = cep.logradouro;
                        Txt_Complemento.Text = cep.complemento;
                        Txt_Cidade.Text = cep.localidade;
                        Txt_Bairro.Text = cep.bairro;
                        Cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + cep.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        Cliente LeituraFormulario()
        {
            Cliente c = new Cliente();
            c.u_nome = Txt_NomeCliente.Text;
            c.u_rg = Txt_Rg.Text;
            c.u_cpf = Txt_CPF.Text;
            if(Txt_Senha.Text == Txt_SenhaConfirmacao.Text)
            {
                c.u_senha = Txt_Senha.Text;
            }

            c.u_cep = Txt_CEP.Text;
            c.u_logradouro = Txt_Logradouro.Text;
            c.u_complemento = Txt_Complemento.Text;
            c.u_cidade = Txt_Cidade.Text;
            c.u_bairro = Txt_Bairro.Text;
            if (Cmb_Estados.SelectedIndex < 0)
            {
                c.u_estado = "";
            }
            else
            {
                 c.u_estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            c.ctt_tel = Txt_Telefone.Text;
            c.ctt_cel = Txt_Celular.Text;


            c.c_profissao = Txt_Profissao.Text;
            c.u_usario = Txt_Usuario.Text;

            return c;
        }


        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e) {

        }

        private void Grp_DadosPessoais_Enter(object sender, EventArgs e) {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u = LeituraFormulario();
                u.ValidaClasse();
                u.ValidaComplemento();
                connect.ExecutaSQL("INSERT INTO usuario (u_cpf,u_rg,u_senha,u_nome,u_logradouro,u_complemento,u_bairro,u_cidade,u_estado,u_cep)VALUES('" + Convert.ToString(u.u_cpf) + "','" + Convert.ToString(u.u_rg) + "','" + Convert.ToString(u.u_senha) + "','" + Convert.ToString(u.u_nome) + "','" + Convert.ToString(u.u_logradouro) + "','" + Convert.ToString(u.u_complemento) + "','" + Convert.ToString(u.u_bairro) + "','" + Convert.ToString(u.u_cidade) + "','" + Convert.ToString(u.u_estado) + "','" + Convert.ToString(u.u_cep) + "');");
                DataTable query = connect.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(u.u_cpf)}';");
                //Messagebox.show($"funcionou {query.rows[0]["u_id"]}");
                connect.ExecutaSQL($"INSERT INTO contato (ctt_id_usuario,ctt_tel,ctt_cel,ctt_email) VALUES ({query.Rows[0]["u_id"]},'{Convert.ToString(u.ctt_tel)}','{Convert.ToString(u.ctt_cel)}','{Convert.ToString(u.ctt_email)}');");
                DataTable query2 = connect.RetornaSQL($"SELECT ctt_id FROM contato WHERE ctt_id_usuario = {query.Rows[0]["u_id"]};");
                connect.ExecutaSQL($"UPDATE usuario SET u_ctt_id = {query2.Rows[0]["ctt_id"]} WHERE u_cpf = '{Convert.ToString(u.u_cpf)}';");
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e) 
        {

        }
    }
}