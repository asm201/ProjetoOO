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

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Lbl_CPF_Click(object sender, EventArgs e) {

        }

        private void Buscar_Click(object sender, EventArgs e) {

        }

        private void Inserir_Click(object sender, EventArgs e) {
            if (Txt_Nome.Text == string.Empty || Txt_Bairro.Text == string.Empty || Txt_Celular.Text == string.Empty || Txt_Cidade.Text == string.Empty || Txt_CPF.Text == string.Empty || Txt_Departamento.Text == string.Empty || Txt_Email.Text == string.Empty || Txt_Funcao.Text == string.Empty || Txt_Logradouro.Text == string.Empty || Txt_Rg.Text == string.Empty || Txt_Salario.Text == string.Empty || Txt_Telefone.Text == string.Empty){
                MessageBox.Show("É necessário preencher todos os campos!");
            } else {
                try {
                    DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(Txt_CPF.Text)}';");
                    conexao.ExecutaSQL($"INSERT INTO funcionario (f_id_usuario, f_salario, f_departamento, f_funcao) VALUES ({query.Rows[0]["u_id"]},{float.Parse(Txt_Salario.Text)},{Txt_Departamento.Text},{Txt_Funcao.Text});");
                    DataTable query2 = conexao.RetornaSQL($"SELECT f_id FROM funcionario WHERE f_id_usuario = {query.Rows[0]["u_id"]}");
                    conexao.ExecutaSQL($"UPDATE usuario SET u_id_funcionario = {query2.Rows[0]["f_id"]}");
                    MessageBox.Show("Cadastro realizado com sucesso!");
                } catch (Exception a) {
                    MessageBox.Show("Erro: funcionário não encontrado no sistema. " + a.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void AcessoFuncionarios_Load(object sender, EventArgs e) {
            try {
                dataGridView2.DataSource = conexao.RetornaSQL($" SELECT u.u_nome, u.u_cpf,u.u_rg,u.u_logradouro,u.u_bairro,u.u_cidade,u.u_estado,c.ctt_tel,c.ctt_cel,c.ctt_email,f.f_salario,f.f_departamento,f.f_funcao FROM usuario u INNER JOIN contato c ON u.u_id = c.ctt_id_usuario INNER JOIN funcionario f ON u.u_id = f.f_id_usuario;");
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
