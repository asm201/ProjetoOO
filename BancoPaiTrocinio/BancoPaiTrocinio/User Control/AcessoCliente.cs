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
    public partial class AcessoCliente : UserControl
    {

        private static ConexaoMySql conexao;
        public string strGelio = @"SELECT u.u_nome,u.u_cpf,u.u_departamento,u.u_rg,u.u_logradouro,u.u_complemento,
                                   u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                                   c.c_profissao,cb.cb_agencia, ";
        public Boolean jp;
        
        public AcessoCliente()
        {
            InitializeComponent();
        }

        public string Manipula_String(string s) {
            
            
            return s;
        }

        private void AcessoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                string radioText;
                foreach(RadioButton r in Grp_TipoConta.Controls) {
                    if (r.Checked) {
                        radioText = r.Text;
                    }
                }
                Manipula_String(strGelio);
                dataGridView2.DataSource = conexao.RetornaSQL(strGelio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Buscar_Click(object sender, EventArgs e) {
            if (TxtBusca.Text == string.Empty) {
                MessageBox.Show("Digite um CPF!");
            }else {

            }
        }
    }
}
