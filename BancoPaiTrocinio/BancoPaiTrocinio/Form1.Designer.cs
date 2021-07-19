namespace BancoPaiTrocinio
{
    partial class Frm_BancoPaiTrocinio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depositarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(800, 426);
            this.Tbc_Aplicacoes.TabIndex = 3;
            this.Tbc_Aplicacoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Aplicacoes_MouseDown);
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.gerenteDeClientesToolStripMenuItem,
            this.diretorToolStripMenuItem1});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
            this.Mnu_Principal.TabIndex = 2;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.arquivoToolStripMenuItem.Text = "Inicio";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenteDeContasToolStripMenuItem,
            this.diretorToolStripMenuItem});
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // gerenteDeContasToolStripMenuItem
            // 
            this.gerenteDeContasToolStripMenuItem.Name = "gerenteDeContasToolStripMenuItem";
            this.gerenteDeContasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerenteDeContasToolStripMenuItem.Text = "Gerente De Contas";
            this.gerenteDeContasToolStripMenuItem.Click += new System.EventHandler(this.gerenteDeContasToolStripMenuItem_Click);
            // 
            // diretorToolStripMenuItem
            // 
            this.diretorToolStripMenuItem.Name = "diretorToolStripMenuItem";
            this.diretorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.diretorToolStripMenuItem.Text = "Diretor";
            this.diretorToolStripMenuItem.Click += new System.EventHandler(this.diretorToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositarToolStripMenuItem,
            this.transferirToolStripMenuItem,
            this.verSaldoToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // depositarToolStripMenuItem
            // 
            this.depositarToolStripMenuItem.Name = "depositarToolStripMenuItem";
            this.depositarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.depositarToolStripMenuItem.Text = "Depositar";
            // 
            // transferirToolStripMenuItem
            // 
            this.transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            this.transferirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.transferirToolStripMenuItem.Text = "Transferir";
            // 
            // verSaldoToolStripMenuItem
            // 
            this.verSaldoToolStripMenuItem.Name = "verSaldoToolStripMenuItem";
            this.verSaldoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.verSaldoToolStripMenuItem.Text = "Ver saldo";
            // 
            // gerenteDeClientesToolStripMenuItem
            // 
            this.gerenteDeClientesToolStripMenuItem.Name = "gerenteDeClientesToolStripMenuItem";
            this.gerenteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gerenteDeClientesToolStripMenuItem.Text = "Gerente de Contas";
            this.gerenteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gerenteDeClientesToolStripMenuItem_Click);
            // 
            // diretorToolStripMenuItem1
            // 
            this.diretorToolStripMenuItem1.Name = "diretorToolStripMenuItem1";
            this.diretorToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.diretorToolStripMenuItem1.Text = "Diretor";
            this.diretorToolStripMenuItem1.Click += new System.EventHandler(this.diretorToolStripMenuItem1_Click);
            // 
            // Frm_BancoPaiTrocinio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Mnu_Principal);
            this.Name = "Frm_BancoPaiTrocinio";
            this.Text = "Banco Pai Trocinio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_BancoPaiTrocinio_Load);
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenteDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diretorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diretorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depositarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSaldoToolStripMenuItem;
    }
}
