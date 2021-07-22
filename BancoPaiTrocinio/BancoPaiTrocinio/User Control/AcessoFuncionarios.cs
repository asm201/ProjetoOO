using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPaiTrocinio.User_Control {
    public partial class AcessoFuncionarios : UserControl {

        public string strGelio = "SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_complemento,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao,u.u_usuario,u.u_senha FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;";
        Conexões.ConexaoMySql conexao = new Conexões.ConexaoMySql();
        public AcessoFuncionarios() {
            InitializeComponent();
        }

        private void LimpaTxt() {
            Txt_Nome.Text = "";
            Txt_Bairro.Text = "";
            Txt_Celular.Text = "";
            Txt_Cidade.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Txt_Departamento.Text = "";
            Txt_Email.Text = "";
            Txt_Estado.Text = "";
            Txt_Funcao.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Rg.Text = "";
            Txt_Salario.Text = "";
            Txt_Telefone.Text = "";
        }

        //public void AtualizaGrid() {
        //    try {
        //        dataGridView2.DataSource = conexao.RetornaSQL(" SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;");
        //        dataGridView2.Show();
        //    } catch (Exception ex) {
        //        MessageBox.Show("Erro: " + ex.Message);
        //    }
        //}

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Lbl_CPF_Click(object sender, EventArgs e) {

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
                    conexao.ExecutaSQL($"INSERT INTO usuario (u_usuario, u_cpf,u_rg,u_senha,u_nome,u_logradouro,u_complemento,u_bairro,u_cidade,u_estado,u_cep)VALUES('" + Convert.ToString(Txt_Usuario.Text) + "','" + Convert.ToString(Txt_CPF.Text) + "','" + Convert.ToString(Txt_Rg.Text) + "','" + Convert.ToString(Txt_Senha.Text) + "','" + Convert.ToString(Txt_Nome.Text) + "','" + Convert.ToString(Txt_Logradouro.Text) + "','" + Convert.ToString(Txt_Complemento.Text) + "','" + Convert.ToString(Txt_Bairro.Text) + "','" + Convert.ToString(Txt_Cidade.Text) + "','" + Convert.ToString(Txt_Estado.Text) + "','" + Convert.ToString(Txt_CEP.Text) + "');");
                    DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(Txt_CPF.Text)}';");
                    conexao.ExecutaSQL($"INSERT INTO funcionario (f_id_usuario, f_salario, f_departamento, f_funcao) VALUES ({query.Rows[0]["u_id"]},'{float.Parse(Txt_Salario.Text)}','{Txt_Departamento.Text}','{Txt_Funcao.Text}');");
                    DataTable query2 = conexao.RetornaSQL($"SELECT f_id FROM funcionario WHERE f_id_usuario = {query.Rows[0]["u_id"]}");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_id_funcionario = {query2.Rows[0]["f_id"]} WHERE u_cpf = '{Convert.ToString(Txt_CPF.Text)}';");
                    conexao.ExecutaSQL($"INSERT INTO contato (ctt_id_usuario,ctt_tel,ctt_cel,ctt_email) VALUES ({query.Rows[0]["u_id"]},'{Convert.ToString(Txt_Telefone.Text)}','{Convert.ToString(Txt_Celular.Text)}','{Convert.ToString(Txt_Email.Text)}');");
                    DataTable query3 = conexao.RetornaSQL($"SELECT ctt_id FROM contato WHERE ctt_id_usuario = {query.Rows[0]["u_id"]};");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_ctt_id = {query3.Rows[0]["ctt_id"]} WHERE u_cpf = '{Convert.ToString(Txt_CPF.Text)}';");
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
            conexao.ExecutaSQL($"DELETE FROM usuario WHERE u_cpf = {Convert.ToString(Txt_CPF.Text)};");
        }
    }
}
