namespace BancoPaiTrocinio.User_Control
{
    partial class AcessoCliente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Atualizar = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.cpf_busca = new System.Windows.Forms.Label();
            this.Lbl_Rg = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Rg = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.dados_cliente = new System.Windows.Forms.GroupBox();
            this.lblprofissao = new System.Windows.Forms.Label();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Grp_TipoConta = new System.Windows.Forms.GroupBox();
            this.Rdb_ContaPoupanca = new System.Windows.Forms.RadioButton();
            this.Rdb_ContaCorrente = new System.Windows.Forms.RadioButton();
            this.Lbl_NumeroAgencia = new System.Windows.Forms.Label();
            this.Txt_NumeroAgencia = new System.Windows.Forms.TextBox();
            this.Txt_NumeroConta = new System.Windows.Forms.TextBox();
            this.Lbl_NumeroConta = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dados_cliente.SuspendLayout();
            this.Grp_TipoConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Atualizar
            // 
            this.Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Atualizar.Location = new System.Drawing.Point(685, 117);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 2;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // Inserir
            // 
            this.Inserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Inserir.Location = new System.Drawing.Point(685, 155);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 3;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.Location = new System.Drawing.Point(685, 194);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 4;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(669, 29);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(109, 20);
            this.TxtBusca.TabIndex = 5;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(685, 56);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // cpf_busca
            // 
            this.cpf_busca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpf_busca.AutoSize = true;
            this.cpf_busca.Location = new System.Drawing.Point(670, 10);
            this.cpf_busca.Name = "cpf_busca";
            this.cpf_busca.Size = new System.Drawing.Size(69, 13);
            this.cpf_busca.TabIndex = 7;
            this.cpf_busca.Text = "Digite o CPF:";
            // 
            // Lbl_Rg
            // 
            this.Lbl_Rg.AutoSize = true;
            this.Lbl_Rg.Location = new System.Drawing.Point(23, 67);
            this.Lbl_Rg.Name = "Lbl_Rg";
            this.Lbl_Rg.Size = new System.Drawing.Size(23, 13);
            this.Lbl_Rg.TabIndex = 51;
            this.Lbl_Rg.Text = "RG";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(274, 66);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(107, 13);
            this.Lbl_Telefone.TabIndex = 52;
            this.Lbl_Telefone.Text = "Telefone Residencial";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(277, 82);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(171, 20);
            this.Txt_Telefone.TabIndex = 48;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Email.Location = new System.Drawing.Point(277, 127);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(353, 20);
            this.Txt_Email.TabIndex = 53;
            // 
            // Txt_Rg
            // 
            this.Txt_Rg.Location = new System.Drawing.Point(26, 81);
            this.Txt_Rg.Name = "Txt_Rg";
            this.Txt_Rg.Size = new System.Drawing.Size(103, 20);
            this.Txt_Rg.TabIndex = 50;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(274, 111);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Email.TabIndex = 54;
            this.Lbl_Email.Text = "E-mail";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(274, 26);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 49;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Celular.Location = new System.Drawing.Point(463, 82);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(167, 20);
            this.Txt_Celular.TabIndex = 55;
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(277, 42);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(200, 20);
            this.Txt_CPF.TabIndex = 47;
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Location = new System.Drawing.Point(460, 66);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(84, 13);
            this.Lbl_Celular.TabIndex = 56;
            this.Lbl_Celular.Text = "Telefone Celular";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(26, 42);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(245, 20);
            this.Txt_Nome.TabIndex = 57;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(23, 26);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 58;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(23, 151);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(61, 13);
            this.lbl_logradouro.TabIndex = 59;
            this.lbl_logradouro.Text = "Logradouro";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(26, 167);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(245, 20);
            this.Txt_Logradouro.TabIndex = 60;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(26, 260);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(245, 20);
            this.Txt_Cidade.TabIndex = 61;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(26, 244);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 62;
            this.lbl_cidade.Text = "Cidade";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Estado.Location = new System.Drawing.Point(463, 167);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(167, 20);
            this.Txt_Estado.TabIndex = 64;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(274, 151);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 65;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(460, 151);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 66;
            this.lbl_estado.Text = "Estado";
            // 
            // dados_cliente
            // 
            this.dados_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dados_cliente.Controls.Add(this.lblprofissao);
            this.dados_cliente.Controls.Add(this.Txt_Profissao);
            this.dados_cliente.Controls.Add(this.lblCEP);
            this.dados_cliente.Controls.Add(this.Txt_CEP);
            this.dados_cliente.Controls.Add(this.Grp_TipoConta);
            this.dados_cliente.Controls.Add(this.Lbl_NumeroAgencia);
            this.dados_cliente.Controls.Add(this.Txt_NumeroAgencia);
            this.dados_cliente.Controls.Add(this.Txt_NumeroConta);
            this.dados_cliente.Controls.Add(this.Lbl_NumeroConta);
            this.dados_cliente.Controls.Add(this.lbl_complemento);
            this.dados_cliente.Controls.Add(this.Txt_Complemento);
            this.dados_cliente.Controls.Add(this.lbl_salario);
            this.dados_cliente.Controls.Add(this.Txt_Saldo);
            this.dados_cliente.Controls.Add(this.lbl_estado);
            this.dados_cliente.Controls.Add(this.lbl_bairro);
            this.dados_cliente.Controls.Add(this.Txt_Estado);
            this.dados_cliente.Controls.Add(this.Txt_Bairro);
            this.dados_cliente.Controls.Add(this.lbl_cidade);
            this.dados_cliente.Controls.Add(this.Txt_Cidade);
            this.dados_cliente.Controls.Add(this.Txt_Logradouro);
            this.dados_cliente.Controls.Add(this.lbl_logradouro);
            this.dados_cliente.Controls.Add(this.lbl_nome);
            this.dados_cliente.Controls.Add(this.Txt_Nome);
            this.dados_cliente.Controls.Add(this.Lbl_Celular);
            this.dados_cliente.Controls.Add(this.Txt_CPF);
            this.dados_cliente.Controls.Add(this.Txt_Celular);
            this.dados_cliente.Controls.Add(this.Lbl_CPF);
            this.dados_cliente.Controls.Add(this.Lbl_Email);
            this.dados_cliente.Controls.Add(this.Txt_Rg);
            this.dados_cliente.Controls.Add(this.Txt_Email);
            this.dados_cliente.Controls.Add(this.Txt_Telefone);
            this.dados_cliente.Controls.Add(this.Lbl_Telefone);
            this.dados_cliente.Controls.Add(this.Lbl_Rg);
            this.dados_cliente.Location = new System.Drawing.Point(4, 3);
            this.dados_cliente.Name = "dados_cliente";
            this.dados_cliente.Size = new System.Drawing.Size(659, 300);
            this.dados_cliente.TabIndex = 1;
            this.dados_cliente.TabStop = false;
            this.dados_cliente.Text = "Dados do Cliente";
            //
            // lblprofissao
            // 
            this.lblprofissao.AutoSize = true;
            this.lblprofissao.Location = new System.Drawing.Point(135, 66);
            this.lblprofissao.Name = "lblprofissao";
            this.lblprofissao.Size = new System.Drawing.Size(50, 13);
            this.lblprofissao.TabIndex = 83;
            this.lblprofissao.Text = "Profissão";
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Location = new System.Drawing.Point(135, 81);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(136, 20);
            this.Txt_Profissao.TabIndex = 82;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(26, 109);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 81;
            this.lblCEP.Text = "CEP";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(26, 126);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(245, 20);
            this.Txt_CEP.TabIndex = 80;
            //
            // Grp_TipoConta
            // 
            this.Grp_TipoConta.Controls.Add(this.Rdb_ContaPoupanca);
            this.Grp_TipoConta.Controls.Add(this.Rdb_ContaCorrente);
            this.Grp_TipoConta.Location = new System.Drawing.Point(328, 200);
            this.Grp_TipoConta.Name = "Grp_TipoConta";
            this.Grp_TipoConta.Size = new System.Drawing.Size(279, 45);
            this.Grp_TipoConta.TabIndex = 79;
            this.Grp_TipoConta.TabStop = false;
            this.Grp_TipoConta.Text = "Tipo da Conta";
            // 
            // Rdb_ContaPoupanca
            // 
            this.Rdb_ContaPoupanca.AutoSize = true;
            this.Rdb_ContaPoupanca.Location = new System.Drawing.Point(157, 19);
            this.Rdb_ContaPoupanca.Name = "Rdb_ContaPoupanca";
            this.Rdb_ContaPoupanca.Size = new System.Drawing.Size(105, 17);
            this.Rdb_ContaPoupanca.TabIndex = 1;
            this.Rdb_ContaPoupanca.Text = "Conta Poupança";
            this.Rdb_ContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // Rdb_ContaCorrente
            // 
            this.Rdb_ContaCorrente.AutoSize = true;
            this.Rdb_ContaCorrente.Checked = true;
            this.Rdb_ContaCorrente.Location = new System.Drawing.Point(25, 19);
            this.Rdb_ContaCorrente.Name = "Rdb_ContaCorrente";
            this.Rdb_ContaCorrente.Size = new System.Drawing.Size(96, 17);
            this.Rdb_ContaCorrente.TabIndex = 0;
            this.Rdb_ContaCorrente.TabStop = true;
            this.Rdb_ContaCorrente.Text = "Conta Corrente";
            this.Rdb_ContaCorrente.UseVisualStyleBackColor = true;
            // 
            // Lbl_NumeroAgencia
            // 
            this.Lbl_NumeroAgencia.AutoSize = true;
            this.Lbl_NumeroAgencia.Location = new System.Drawing.Point(474, 244);
            this.Lbl_NumeroAgencia.Name = "Lbl_NumeroAgencia";
            this.Lbl_NumeroAgencia.Size = new System.Drawing.Size(101, 13);
            this.Lbl_NumeroAgencia.TabIndex = 78;
            this.Lbl_NumeroAgencia.Text = "Numero da Agencia";
            // 
            // Txt_NumeroAgencia
            // 
            this.Txt_NumeroAgencia.Location = new System.Drawing.Point(463, 260);
            this.Txt_NumeroAgencia.Name = "Txt_NumeroAgencia";
            this.Txt_NumeroAgencia.Size = new System.Drawing.Size(166, 20);
            this.Txt_NumeroAgencia.TabIndex = 77;
            // 
            // Txt_NumeroConta
            // 
            this.Txt_NumeroConta.Location = new System.Drawing.Point(277, 260);
            this.Txt_NumeroConta.Name = "Txt_NumeroConta";
            this.Txt_NumeroConta.Size = new System.Drawing.Size(171, 20);
            this.Txt_NumeroConta.TabIndex = 76;
            // 
            // Lbl_NumeroConta
            // 
            this.Lbl_NumeroConta.AutoSize = true;
            this.Lbl_NumeroConta.Location = new System.Drawing.Point(277, 244);
            this.Lbl_NumeroConta.Name = "Lbl_NumeroConta";
            this.Lbl_NumeroConta.Size = new System.Drawing.Size(90, 13);
            this.Lbl_NumeroConta.TabIndex = 75;
            this.Lbl_NumeroConta.Text = "Numero da Conta";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(26, 200);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(71, 13);
            this.lbl_complemento.TabIndex = 74;
            this.lbl_complemento.Text = "Complemento";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(26, 215);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(245, 20);
            this.Txt_Complemento.TabIndex = 73;
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(480, 26);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(34, 13);
            this.lbl_salario.TabIndex = 71;
            this.lbl_salario.Text = "Saldo";
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Saldo.Location = new System.Drawing.Point(483, 42);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(147, 20);
            this.Txt_Saldo.TabIndex = 67;
            this.Txt_Saldo.Text = "R$";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(277, 167);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(171, 20);
            this.Txt_Bairro.TabIndex = 63;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(770, 217);
            this.dataGridView2.TabIndex = 8;
            // 
            // AcessoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cpf_busca);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.dados_cliente);
            this.Name = "AcessoCliente";
            this.Size = new System.Drawing.Size(781, 532);
            this.Load += new System.EventHandler(this.AcessoCliente_Load);
            this.dados_cliente.ResumeLayout(false);
            this.dados_cliente.PerformLayout();
            this.Grp_TipoConta.ResumeLayout(false);
            this.Grp_TipoConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label cpf_busca;
        private System.Windows.Forms.Label Lbl_Rg;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Txt_Telefone;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Rg;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_logradouro;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.GroupBox dados_cliente;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_NumeroAgencia;
        private System.Windows.Forms.TextBox Txt_NumeroAgencia;
        private System.Windows.Forms.TextBox Txt_NumeroConta;
        private System.Windows.Forms.Label Lbl_NumeroConta;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.GroupBox Grp_TipoConta;
        private System.Windows.Forms.RadioButton Rdb_ContaPoupanca;
        private System.Windows.Forms.RadioButton Rdb_ContaCorrente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.Label lblprofissao;
        private System.Windows.Forms.TextBox Txt_Profissao;
    }
}