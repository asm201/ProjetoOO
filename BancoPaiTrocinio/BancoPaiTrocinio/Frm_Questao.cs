using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPaiTrocinio
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();
            Image myImage = (Image)global::BancoPaiTrocinio.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = myImage;

            Lbl_Questao.Text = mensagem;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancela_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
