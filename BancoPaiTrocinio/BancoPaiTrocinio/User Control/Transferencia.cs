using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.Classes;


namespace BancoPaiTrocinio.User_Control
{
    public partial class Transferencia : UserControl
    {
        ContaCorrente clienteCorrente;
        ContaPoupanca clientePoupanca;
        public Transferencia(ContaPoupanca cp = null, ContaCorrente cc = null)
        {
            InitializeComponent();
            clienteCorrente = cc;
            clientePoupanca = cp;
        }

        private void Btn_Transferir_Click(object sender, EventArgs e)
        {
            if (clienteCorrente == null)
            {
                try
                {
                    clientePoupanca.Transferir(Convert.ToDouble(Txt_Valor.Text), Txt_NumeroConta.Text);
                    MessageBox.Show("Tranferencia feito com sucesso", "Banco Paitrocinio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "Banco Paitrocinio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (clientePoupanca == null)
            {
                try
                {
                    clienteCorrente.Transferir(Convert.ToDouble(Txt_Valor.Text), Txt_NumeroConta.Text);
                    MessageBox.Show("Tranferencia feito com sucesso", "Banco Paitrocinio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Banco Paitrocinio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
