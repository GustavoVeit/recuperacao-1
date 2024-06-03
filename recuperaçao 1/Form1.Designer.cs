namespace recuperaçao_1
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
            this.btnTela1 = new System.Windows.Forms.Button();
            this.btnTela2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTela1
            // 
            this.btnTela1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTela1.Location = new System.Drawing.Point(169, 226);
            this.btnTela1.Name = "btnTela1";
            this.btnTela1.Size = new System.Drawing.Size(148, 47);
            this.btnTela1.TabIndex = 0;
            this.btnTela1.Text = "Tela 1";
            this.btnTela1.UseVisualStyleBackColor = true;
            this.btnTela1.Click += new System.EventHandler(this.btnTela1_Click);
            // 
            // btnTela2
            // 
            this.btnTela2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTela2.Location = new System.Drawing.Point(441, 226);
            this.btnTela2.Name = "btnTela2";
            this.btnTela2.Size = new System.Drawing.Size(148, 47);
            this.btnTela2.TabIndex = 1;
            this.btnTela2.Text = "Tela 2 ";
            this.btnTela2.UseVisualStyleBackColor = true;
            this.btnTela2.Click += new System.EventHandler(this.btnTela2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um dos Forms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTela2);
            this.Controls.Add(this.btnTela1);
            this.Name = "Form1";
            this.Text = "Tela1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTela1;
        private System.Windows.Forms.Button btnTela2;
        private System.Windows.Forms.Label label1;
    }
}

