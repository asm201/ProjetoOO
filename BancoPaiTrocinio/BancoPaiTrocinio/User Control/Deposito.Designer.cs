namespace BancoPaiTrocinio.User_Control
{
    partial class Deposito
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
            this.Btn_Depositar = new System.Windows.Forms.Button();
            this.Lbl_Depositar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Depositar
            // 
            this.Btn_Depositar.Location = new System.Drawing.Point(662, 120);
            this.Btn_Depositar.Name = "Btn_Depositar";
            this.Btn_Depositar.Size = new System.Drawing.Size(125, 23);
            this.Btn_Depositar.TabIndex = 0;
            this.Btn_Depositar.Text = "Depositar";
            this.Btn_Depositar.UseVisualStyleBackColor = true;
            this.Btn_Depositar.Click += new System.EventHandler(this.Btn_Depositar_Click);
            // 
            // Lbl_Depositar
            // 
            this.Lbl_Depositar.AutoSize = true;
            this.Lbl_Depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Depositar.Location = new System.Drawing.Point(465, 13);
            this.Lbl_Depositar.Name = "Lbl_Depositar";
            this.Lbl_Depositar.Size = new System.Drawing.Size(540, 25);
            this.Lbl_Depositar.TabIndex = 1;
            this.Lbl_Depositar.Text = "Qual o valor que você deseja depositar em sua conta ?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(622, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_Depositar);
            this.Controls.Add(this.Btn_Depositar);
            this.Name = "Deposito";
            this.Size = new System.Drawing.Size(1310, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Depositar;
        private System.Windows.Forms.Label Lbl_Depositar;
        private System.Windows.Forms.TextBox textBox1;
    }
}
