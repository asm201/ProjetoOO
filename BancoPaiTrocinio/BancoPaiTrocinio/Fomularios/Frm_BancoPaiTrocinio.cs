using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.User_Control;
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio
{
    public partial class Frm_BancoPaiTrocinio : Form
    {
        int controleCadastroCliente = 0;
        int controleAcessoFunc = 0;
        int controleVerDados = 0;
        int controleDepositar = 0;
        int controleTransferir = 0;
        int controleAcessoCliente = 0;

        Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
        ContaCorrente clienteCorrente;
        ContaPoupanca clientePoupanca;

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


            if (Cls_Uteis.ValidaLogin(senha, login) == true)
            {

                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                clienteToolStripMenuItem1.Enabled = true;
                cadastrarToolStripMenuItem.Enabled = false;

                if (!(Tbc_Aplicacoes.SelectedTab == null))
                {
                    ApagaAba(Tbc_Aplicacoes.SelectedTab);
                }

                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (Cls_Uteis.VerificaConta(senha, login)){
                    case "Conta Corrente":
                        clienteCorrente = GeraContaCorrente(senha,login);
                        clientePoupanca = null;

                        break;
                    
                    case "Conta Poupança":
                        clientePoupanca = GeraContaPoupanca(senha,login);
                        clienteCorrente = null;

                        break;
                    
                    default:
                        throw new NullReferenceException("Este cliente não é gay");
                }
            }
            else
            {
                MessageBox.Show("Senha Invalida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private ContaCorrente GeraContaCorrente(string senha,string login) {
            ContaCorrente cc = new ContaCorrente();
            DataTable query = connect.RetornaSQL(@"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                                                               u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                                                               c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo,
                                                               u.u_usuario, u.u_senha, cc.cc_id
                                                               FROM usuario u INNER JOIN contato ct ON u.u_id = ct.ctt_id_usuario
                                                               INNER JOIN cliente c ON u.u_id_cliente = c.c_id
                                                               INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                                                               INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id
                                                               WHERE u.u_usuario = '" + login + "' AND u.u_senha = '" + senha + "';");
            
            cc.u_nome = (string)query.Rows[0][0];
            cc.u_cpf = (string)query.Rows[0][1];
            cc.u_rg = (string)query.Rows[0][2];
            cc.u_cep = (string)query.Rows[0][3];
            cc.u_logradouro = (string)query.Rows[0][4];
            cc.u_complemento = (string)query.Rows[0][5];
            cc.u_cidade = (string)query.Rows[0][6];
            cc.u_bairro = (string)query.Rows[0][7];
            cc.u_estado = (string)query.Rows[0][8];
            cc.ctt_tel = (string)query.Rows[0][9];
            cc.ctt_cel = (string)query.Rows[0][10];
            cc.ctt_email = (string)query.Rows[0][11];
            cc.c_profissao = (string)query.Rows[0][12];
            cc.cb_agencia = (int)query.Rows[0][13];
            cc.cc_nr_conta_corrente = (int)query.Rows[0][14];
            cc.cc_saldo = Convert.ToDouble(query.Rows[0][15]);
            cc.u_usario = (string)query.Rows[0][16];
            cc.u_senha = (string)query.Rows[0][17];
            cc.cc_id = (int)query.Rows[0][18];

            return cc;

        }

        private ContaPoupanca GeraContaPoupanca(string senha, string login) {
            ContaPoupanca cc = new ContaPoupanca();
            DataTable query = connect.RetornaSQL(@"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                                                               u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                                                               c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor,
                                                               u.u_usuario, u.u_senha, cp.cp_id
                                                               FROM usuario u INNER JOIN contato ct ON u.u_id = ct.ctt_id_usuario
                                                               INNER JOIN cliente c ON u.u_id_cliente = c.c_id
                                                               INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                                                               INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id
                                                               WHERE u.u_usuario = '" + login + "' AND u.u_senha = '" + senha + "';");

            cc.u_nome = (string)query.Rows[0][0];
            cc.u_cpf = (string)query.Rows[0][1];
            cc.u_rg = (string)query.Rows[0][2];
            cc.u_cep = (string)query.Rows[0][3];
            cc.u_logradouro = (string)query.Rows[0][4];
            cc.u_complemento = (string)query.Rows[0][5];
            cc.u_cidade = (string)query.Rows[0][6];
            cc.u_bairro = (string)query.Rows[0][7];
            cc.u_estado = (string)query.Rows[0][8];
            cc.ctt_tel = (string)query.Rows[0][9];
            cc.ctt_cel = (string)query.Rows[0][10];
            cc.ctt_email = (string)query.Rows[0][11];
            cc.c_profissao = (string)query.Rows[0][12];
            cc.cb_agencia = (int)query.Rows[0][13];
            cc.cp_nr_conta_poupanca = (int)query.Rows[0][14];
            cc.cp_saldo = Convert.ToDouble(query.Rows[0][15]);
            cc.u_usario = (string)query.Rows[0][16];
            cc.u_senha = (string)query.Rows[0][17];
            cc.cp_id = (int)query.Rows[0][18];

            return cc;

        }

        private void gerenteDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login u = new Frm_Login();
            u.ShowDialog();
            string senha = u.senha;
            string login = u.login;
            string funcao = "Gerente de Contas";

            if (Cls_Uteis.ValidaLogin(senha, login) == true && Cls_Uteis.ValidaFuncao(senha, login, funcao))
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                gerenteDeClientesToolStripMenuItem.Enabled = true;
                cadastrarToolStripMenuItem.Enabled = false;

                if (!(Tbc_Aplicacoes.SelectedTab == null))
                {
                    ApagaAba(Tbc_Aplicacoes.SelectedTab);
                }

                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login inválido! Por favor, verifique se está logando no campo correto.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login u = new Frm_Login();
            u.ShowDialog();
            string senha = u.senha;
            string login = u.login;
            string funcao = "Diretor";

            if (Cls_Uteis.ValidaLogin(senha,login) == true && Cls_Uteis.ValidaFuncao(senha, login, funcao)==true)
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                diretorToolStripMenuItem1.Enabled = true;
                cadastrarToolStripMenuItem.Enabled = false;

                if (!(Tbc_Aplicacoes.SelectedTab == null))
                {
                    ApagaAba(Tbc_Aplicacoes.SelectedTab);
                }

                MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login inválido! Por favor, verifique se está logando no campo correto.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao db = new Frm_Questao("question", "Você deseja se desconctar?");
            db.ShowDialog();
            if (db.DialogResult == DialogResult.Yes)
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }


                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrarToolStripMenuItem.Enabled = true;
                diretorToolStripMenuItem1.Enabled = false;
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


                contextMenu.Items.Add(vToolTip1);

                contextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip1.Click += new System.EventHandler(vToolTip1_Click);

            }
        }

        void vToolTip1_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
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




        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleCadastroCliente == 0)
            {
                controleCadastroCliente++;
                CadastroCliente u = new CadastroCliente();
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Cadastro de Clientes";
                tb.Text = "Cadastro de Clientes";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de clientes, pois ja tem um aberto", "Banco Paitrocínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gerenteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleAcessoCliente == 0)
            {
                controleAcessoCliente++;
                AcessoCliente u = new AcessoCliente();
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Acesso ao Cliente";
                tb.Text = "Acesso ao Cliente";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de clientes, pois ja tem um aberto", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void diretorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (controleAcessoFunc == 0) {
                controleAcessoFunc++;
                AcessoFuncionarios u = new AcessoFuncionarios();
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Acesso Funcionarios";
                tb.Text = "Acesso Funcionarios";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            } else {
                MessageBox.Show("Não posso abrir o acesso ao clientes, pois ja tem um aberto", "Banco Paitrocínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ApagaAba(TabPage tb)
        {
            if (tb.Name == "Cadastro de Clientes")
            {
                controleCadastroCliente = 0;
            }
            if (tb.Name == "Acesso ao Cliente")
            {
                controleAcessoCliente = 0;
            }
            if (tb.Name == "Ver Dados")
            {
                controleVerDados = 0;
            }
            if (tb.Name == "Depositar")
            {
                controleDepositar = 0;
            }
            if (tb.Name == "Transferencia")
            {
                controleTransferir = 0;
            }
            if (tb.Name == "Acesso Funcionarios")
            {
                controleAcessoFunc = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(tb);
        }

        private void verSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleVerDados == 0)
            {
                controleVerDados++;
                VerDados u = new VerDados(clientePoupanca, clienteCorrente);
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Ver Dados";
                tb.Text = "Ver Dados";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);

            }
            else
            {
                MessageBox.Show("Não posso abrir os dados de clientes, pois ja tem um aberto", "Banco Paitrocínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleDepositar == 0)
            {
                controleDepositar++;
                Deposito u = new Deposito(clientePoupanca, clienteCorrente);
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Depositar";
                tb.Text = "Depositar";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir esta pagina, pois ja tem um aberto", "Banco Paitrocínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleTransferir == 0)
            {
                controleTransferir++;
                Transferencia u = new Transferencia(clientePoupanca, clienteCorrente);
                TabPage tb = new TabPage();
                u.Dock = DockStyle.Fill;
                tb.Name = "Transferencia";
                tb.Text = "Transferencia";
                tb.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir esta pagina, pois ja tem um aberto", "Banco Paitrocínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

