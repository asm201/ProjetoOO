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
    public partial class Frm_BancoPaiTrocinio : Form
    {
        int controleCadastroCliente = 0;
        int controleCliente = 0;
        public Frm_BancoPaiTrocinio()
        {
            InitializeComponent();
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            clienteToolStripMenuItem1.Enabled = false;
            gerenteDeClientesToolStripMenuItem.Enabled = false;
            diretorToolStripMenuItem1.Enabled = false;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login u = new Frm_Login();
            u.ShowDialog();
            string senha = u.senha;
            string login = u.login;

            if (Cls_Uteis.ValidaSenhaLogin(senha) == true)
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                clienteToolStripMenuItem1.Enabled = true;



                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha Invalida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gerenteDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login u = new Frm_Login();
            u.ShowDialog();
            string senha = u.senha;
            string login = u.login;

            if (Cls_Uteis.ValidaSenhaLogin(senha) == true)
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                gerenteDeClientesToolStripMenuItem.Enabled = true;



                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha Invalida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login u = new Frm_Login();
            u.ShowDialog();
            string senha = u.senha;
            string login = u.login;

            if (Cls_Uteis.ValidaSenhaLogin(senha) == true)
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                diretorToolStripMenuItem.Enabled = true;



                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha Invalida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao db = new Frm_Questao("question", "Você deseja se desconctar?");
            db.ShowDialog();
            //if (MessageBox.Show("Você realmente dejesa validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            if (db.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }


                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrarToolStripMenuItem.Enabled = true;
                diretorToolStripMenuItem.Enabled = false;
                gerenteDeClientesToolStripMenuItem.Enabled = false;
                clienteToolStripMenuItem1.Enabled = false;


            }
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();
                var vToolTip1 = DesenhaItemMenu("Apagar a aba", "DeleteTab");
                var vToolTip2 = DesenhaItemMenu("Apagar todos as abas a esquerda", "DeleteLeft");
                var vToolTip3 = DesenhaItemMenu("Apagar todos as abas a direita", "DeleteRight");
                var vToolTip4 = DesenhaItemMenu("Apagar todas menos essa", "DeleteAll");


                contextMenu.Items.Add(vToolTip1);
                contextMenu.Items.Add(vToolTip2);
                contextMenu.Items.Add(vToolTip3);
                contextMenu.Items.Add(vToolTip4);
                contextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip1.Click += new System.EventHandler(vToolTip1_Click);
                vToolTip2.Click += new System.EventHandler(vToolTip2_Click);
                vToolTip3.Click += new System.EventHandler(vToolTip3_Click);
                vToolTip4.Click += new System.EventHandler(vToolTip4_Click);
            }
        }

        void vToolTip1_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip2_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip3_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip4_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }

        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image myImage = (Image)global::BancoPaiTrocinio.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = myImage;

            return vToolTip;
        }

        void ApagaDireita(int itemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i > itemSelecionado; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        void ApagaEsquerda(int itemSelecionado)
        {
            for (int i = itemSelecionado - 1; i >= 0; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }



        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleCadastroCliente == 0)
            {
                controleCadastroCliente++;
                CadastroCliente u = new CadastroCliente();
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Cadastra de Clientes";
                tb.Text = "Cadastra de Clientes";
                tb.ImageIndex = 7;
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de clientes, pois ja tem um aberto", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gerenteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            if (controleCliente == 0)
            {
                controleCliente++;
                ControleCliente u = new ControleCliente();
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Controle de Clientes";
                tb.Text = "Controle de Clientes";
                tb.ImageIndex = 7;
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de clientes, pois ja tem um aberto", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }*/
        }

        private void diretorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        void ApagaAba(TabPage tb)
        {
            if (tb.Name == "Cadastra de Clientes")
            {
                controleCadastroCliente = 0;
            }
            if (tb.Name == "Controle de Clientes")
            {
                controleCliente = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(tb);
        }

    }
}

