using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio.User_Control {
    public partial class AcessoFuncionarios : UserControl {

        public string strGelio = "SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_complemento,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao,u.u_usuario,u.u_senha FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;";
        Conexões.ConexaoMySql conexao = new Conexões.ConexaoMySql();
        public AcessoFuncionarios() {
            InitializeComponent();

            Txt_Estado.Items.Clear();
            Txt_Estado.Items.Add("Acre (AC)");
            Txt_Estado.Items.Add("Alagoas(AL)");
            Txt_Estado.Items.Add("Amapá(AP)");
            Txt_Estado.Items.Add("Amazonas(AM)");
            Txt_Estado.Items.Add("Bahia(BA)");
            Txt_Estado.Items.Add("Ceará(CE)");
            Txt_Estado.Items.Add("Distrito Federal(DF)");
            Txt_Estado.Items.Add("Espírito Santo(ES)");
            Txt_Estado.Items.Add("Goiás(GO)");
            Txt_Estado.Items.Add("Maranhão(MA)");
            Txt_Estado.Items.Add("Mato Grosso(MT)");
            Txt_Estado.Items.Add("Mato Grosso do Sul(MS)");
            Txt_Estado.Items.Add("Minas Gerais(MG)");
            Txt_Estado.Items.Add("Pará(PA)");
            Txt_Estado.Items.Add("Paraíba(PB)");
            Txt_Estado.Items.Add("Paraná(PR)");
            Txt_Estado.Items.Add("Pernambuco(PE)");
            Txt_Estado.Items.Add("Piauí(PI)");
            Txt_Estado.Items.Add("Rio de Janeiro(RJ)");
            Txt_Estado.Items.Add("Rio Grande do Norte(RN)");
            Txt_Estado.Items.Add("Rio Grande do Sul(RS)");
            Txt_Estado.Items.Add("Rondônia(RO)");
            Txt_Estado.Items.Add("Roraima(RR)");
            Txt_Estado.Items.Add("Santa Catarina(SC)");
            Txt_Estado.Items.Add("São Paulo(SP)");
            Txt_Estado.Items.Add("Sergipe(SE)");
            Txt_Estado.Items.Add("Tocantins(TO)");
        }

        private void LimpaTxt() {
            Txt_Nome.Text = "";
            Txt_Bairro.Text = "";
            Txt_Celular.Text = "";
            Txt_Cidade.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Txt_Departamento.Text = "";
            Txt_Email.Text = "";
            Txt_Estado.SelectedIndex = -1;
            Txt_Funcao.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Rg.Text = "";
            Txt_Salario.Text = "";
            Txt_Telefone.Text = "";
            Txt_Usuario.Text = "";
            Txt_Senha.Text = "";
        }
        //public void AtualizaGrid() {
        //    try {
        //        dataGridView2.DataSource = conexao.RetornaSQL(" SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;");
        //        dataGridView2.Show();
        //    } catch (Exception ex) {
        //        MessageBox.Show("Erro: " + ex.Message);
        //    }
        //}
        Funcionario LeituraFormularioFuncioanario()
        {
            Funcionario f = new Funcionario();
            f.u_nome = Txt_Nome.Text;
            f.u_rg = Txt_Rg.Text;
            f.u_cpf = Txt_CPF.Text;

            f.u_cep = Txt_CEP.Text;
            f.u_logradouro = Txt_Logradouro.Text;
            f.u_complemento = Txt_Complemento.Text;
            f.u_cidade = Txt_Cidade.Text;
            f.u_bairro = Txt_Bairro.Text;

            f.u_estado = Txt_Estado.Text;

            f.ctt_tel = Txt_Telefone.Text;
            f.ctt_cel = Txt_Celular.Text;
            f.ctt_email = Txt_Email.Text;

            f.f_funcao = Txt_Funcao.Text;
            f.f_departamento = Txt_Departamento.Text;
            f.f_salario = Convert.ToDouble(Txt_Salario.Text);
            f.u_usario = Txt_Usuario.Text;
            f.u_senha = Txt_Senha.Text;

            return f;
        }

        private void Buscar_Click(object sender, EventArgs e) {
            this.strGelio = ($"SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_complemento,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao,u.u_usuario,u.u_senha FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario WHERE u.u_cpf = '{Convert.ToString(TxtBusca.Text)}';");
            AcessoFuncionarios_Load(sender, e);
        }

        private void Inserir_Click(object sender, EventArgs e) {
            if (Txt_Nome.Text == string.Empty || Txt_Bairro.Text == string.Empty || Txt_Celular.Text == string.Empty || Txt_Cidade.Text == string.Empty || Txt_CPF.Text == string.Empty || Txt_Departamento.Text == string.Empty || Txt_Email.Text == string.Empty || Txt_Funcao.Text == string.Empty || Txt_Logradouro.Text == string.Empty || Txt_Rg.Text == string.Empty || Txt_Salario.Text == string.Empty || Txt_Telefone.Text == string.Empty || Txt_Usuario.Text == string.Empty || Txt_Senha.Text == string.Empty){
                MessageBox.Show("É necessário preencher todos os campos!");
            } else {
                try {
                    Funcionario f = new Funcionario();
                    f = LeituraFormularioFuncioanario();
                    conexao.ExecutaSQL($"INSERT INTO usuario (u_usuario, u_senha, u_cpf,u_rg,u_senha,u_nome,u_logradouro,u_complemento,u_bairro,u_cidade,u_estado,u_cep)VALUES('" + Convert.ToString(f.u_usario) + "','" + Convert.ToString(f.u_senha) + "','" + Convert.ToString(f.u_cpf) + "','" + Convert.ToString(f.u_rg) + "','" + Convert.ToString(f.u_senha) + "','" + Convert.ToString(f.u_nome) + "','" + Convert.ToString(f.u_logradouro) + "','" + Convert.ToString(f.u_complemento) + "','" + Convert.ToString(f.u_bairro) + "','" + Convert.ToString(f.u_cidade) + "','" + Convert.ToString(f.u_estado) + "','" + Convert.ToString(f.u_cep) + "');");
                    DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(Txt_CPF.Text)}';");
                    conexao.ExecutaSQL($"INSERT INTO funcionario (f_id_usuario, f_salario, f_departamento, f_funcao) VALUES ({query.Rows[0]["u_id"]},'{f.f_salario}','{f.f_departamento}','{f.f_funcao}');");
                    DataTable query2 = conexao.RetornaSQL($"SELECT f_id FROM funcionario WHERE f_id_usuario = {query.Rows[0]["u_id"]}");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_id_funcionario = {query2.Rows[0]["f_id"]} WHERE u_cpf = '{Convert.ToString(f.u_cpf)}';");
                    conexao.ExecutaSQL($"INSERT INTO contato (ctt_id_usuario,ctt_tel,ctt_cel,ctt_email) VALUES ({query.Rows[0]["u_id"]},'{Convert.ToString(f.ctt_tel)}','{Convert.ToString(f.ctt_cel)}','{Convert.ToString(f.ctt_email)}');");
                    DataTable query3 = conexao.RetornaSQL($"SELECT ctt_id FROM contato WHERE ctt_id_usuario = {query.Rows[0]["u_id"]};");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_ctt_id = {query3.Rows[0]["ctt_id"]} WHERE u_cpf = '{Convert.ToString(f.u_cpf)}';");
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    AcessoFuncionarios_Load(sender, e);
                    LimpaTxt();
                } catch (Exception a) {
                    MessageBox.Show("Erro: funcionário não encontrado no sistema. " + a.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Txt_Nome.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            Txt_CPF.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            Txt_Rg.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            Txt_Logradouro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            Txt_Complemento.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            Txt_Bairro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            Txt_Cidade.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            Txt_Estado.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);
            Txt_Telefone.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[8].Value);
            Txt_Celular.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[9].Value);
            Txt_Email.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            Txt_Salario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
            Txt_Departamento.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[12].Value);
            Txt_Funcao.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[13].Value);
            Txt_Usuario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[14].Value);
            Txt_Senha.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[15].Value);
        }

        private void AcessoFuncionarios_Load(object sender, EventArgs e) {
            try {
                dataGridView2.DataSource = conexao.RetornaSQL(this.strGelio);
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Atualizar_Click(object sender, EventArgs e) {
            this.strGelio = "SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_complemento,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao,u.u_usuario,u.u_senha FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;";
            AcessoFuncionarios_Load(sender, e);
        }

        private void Excluir_Click(object sender, EventArgs e) {
            try {
                DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf = {Txt_Excluir.Text}");
                conexao.ExecutaSQL($"DELETE FROM usuario WHERE u_id = {query.Rows[0]["u_id"]};");
                AcessoFuncionarios_Load(sender, e);
            } catch(Exception a) {
                MessageBox.Show(a.Message);
            }
        }
    }
}
