namespace BancoPaiTrocinio.User_Control
{
    partial class Transferencia
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
            this.Lbl_Tranferir = new System.Windows.Forms.Label();
            this.Lbl_NumeroConta = new System.Windows.Forms.Label();
            this.Btn_Transferir = new System.Windows.Forms.Button();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Txt_NumeroConta = new System.Windows.Forms.TextBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Tranferir
            // 
            this.Lbl_Tranferir.AutoSize = true;
            this.Lbl_Tranferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tranferir.Location = new System.Drawing.Point(295, 11);
            this.Lbl_Tranferir.Name = "Lbl_Tranferir";
            this.Lbl_Tranferir.Size = new System.Drawing.Size(850, 25);
            this.Lbl_Tranferir.TabIndex = 0;
            this.Lbl_Tranferir.Text = "Por favor informe o número da conta que se deseja transferir e o valor a ser tran" +
    "sferido.";
            // 
            // Lbl_NumeroConta
            // 
            this.Lbl_NumeroConta.AutoSize = true;
            this.Lbl_NumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroConta.Location = new System.Drawing.Point(448, 72);
            this.Lbl_NumeroConta.Name = "Lbl_NumeroConta";
            this.Lbl_NumeroConta.Size = new System.Drawing.Size(130, 16);
            this.Lbl_NumeroConta.TabIndex = 1;
            this.Lbl_NumeroConta.Text = "Número da conta:";
            // 
            // Btn_Transferir
            // 
            this.Btn_Transferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transferir.Location = new System.Drawing.Point(696, 124);
            this.Btn_Transferir.Name = "Btn_Transferir";
            this.Btn_Transferir.Size = new System.Drawing.Size(128, 23);
            this.Btn_Transferir.TabIndex = 2;
            this.Btn_Transferir.Text = "Transferir";
            this.Btn_Transferir.UseVisualStyleBackColor = true;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(809, 75);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(45, 16);
            this.Lbl_Valor.TabIndex = 3;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Txt_NumeroConta
            // 
            this.Txt_NumeroConta.Location = new System.Drawing.Point(584, 71);
            this.Txt_NumeroConta.Name = "Txt_NumeroConta";
            this.Txt_NumeroConta.Size = new System.Drawing.Size(123, 20);
            this.Txt_NumeroConta.TabIndex = 4;
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(860, 75);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(123, 20);
            this.Txt_Valor.TabIndex = 5;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Txt_NumeroConta);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Btn_Transferir);
            this.Controls.Add(this.Lbl_NumeroConta);
            this.Controls.Add(this.Lbl_Tranferir);
            this.Name = "Transferencia";
            this.Size = new System.Drawing.Size(1310, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tranferir;
        private System.Windows.Forms.Label Lbl_NumeroConta;
        private System.Windows.Forms.Button Btn_Transferir;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.TextBox Txt_NumeroConta;
        private System.Windows.Forms.TextBox Txt_Valor;
    }
}
