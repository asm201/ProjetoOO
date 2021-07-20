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
            //if(conexao.RetornaSQL)==
            //    conexao.ExecutaSQL("INSERT INTO usuario VALUES");
        }
    }
}
