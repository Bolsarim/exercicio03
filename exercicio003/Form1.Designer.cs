namespace exercicio003
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
            this.idadeMaria = new System.Windows.Forms.Label();
            this.idadePatricia = new System.Windows.Forms.Label();
            this.idadeAdriano = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mediaIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idadeMaria
            // 
            this.idadeMaria.AutoSize = true;
            this.idadeMaria.Location = new System.Drawing.Point(169, 31);
            this.idadeMaria.Name = "idadeMaria";
            this.idadeMaria.Size = new System.Drawing.Size(36, 13);
            this.idadeMaria.TabIndex = 0;
            this.idadeMaria.Text = "Maria:";
            // 
            // idadePatricia
            // 
            this.idadePatricia.AutoSize = true;
            this.idadePatricia.Location = new System.Drawing.Point(160, 57);
            this.idadePatricia.Name = "idadePatricia";
            this.idadePatricia.Size = new System.Drawing.Size(45, 13);
            this.idadePatricia.TabIndex = 1;
            this.idadePatricia.Text = "Patricia:";
            // 
            // idadeAdriano
            // 
            this.idadeAdriano.AutoSize = true;
            this.idadeAdriano.Location = new System.Drawing.Point(159, 89);
            this.idadeAdriano.Name = "idadeAdriano";
            this.idadeAdriano.Size = new System.Drawing.Size(46, 13);
            this.idadeAdriano.TabIndex = 2;
            this.idadeAdriano.Text = "Adriano:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mediaIdade
            // 
            this.mediaIdade.Location = new System.Drawing.Point(231, 121);
            this.mediaIdade.Name = "mediaIdade";
            this.mediaIdade.Size = new System.Drawing.Size(70, 20);
            this.mediaIdade.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 345);
            this.Controls.Add(this.mediaIdade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idadeAdriano);
            this.Controls.Add(this.idadePatricia);
            this.Controls.Add(this.idadeMaria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idadeMaria;
        private System.Windows.Forms.Label idadePatricia;
        private System.Windows.Forms.Label idadeAdriano;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mediaIdade;
    }
}

