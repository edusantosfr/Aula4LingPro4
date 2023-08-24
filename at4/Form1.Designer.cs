namespace at4
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonArmazenar = new System.Windows.Forms.Button();
            this.buttonResposta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Valor 1",
            "Valor 2",
            "Valor 3",
            "Valor 4"});
            this.comboBox1.Location = new System.Drawing.Point(195, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Opção ";
            // 
            // buttonArmazenar
            // 
            this.buttonArmazenar.Location = new System.Drawing.Point(456, 102);
            this.buttonArmazenar.Name = "buttonArmazenar";
            this.buttonArmazenar.Size = new System.Drawing.Size(75, 23);
            this.buttonArmazenar.TabIndex = 1;
            this.buttonArmazenar.Text = "Armazenar";
            this.buttonArmazenar.UseVisualStyleBackColor = true;
            this.buttonArmazenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResposta
            // 
            this.buttonResposta.Location = new System.Drawing.Point(313, 158);
            this.buttonResposta.Name = "buttonResposta";
            this.buttonResposta.Size = new System.Drawing.Size(86, 37);
            this.buttonResposta.TabIndex = 2;
            this.buttonResposta.Text = "Resposta";
            this.buttonResposta.UseVisualStyleBackColor = true;
            this.buttonResposta.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coloque na sequencia \r\no valor que será analisado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonResposta);
            this.Controls.Add(this.buttonArmazenar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonArmazenar;
        private System.Windows.Forms.Button buttonResposta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

