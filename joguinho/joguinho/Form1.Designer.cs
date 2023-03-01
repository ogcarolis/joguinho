namespace joguinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgLuna = new System.Windows.Forms.PictureBox();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLuna)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLuna
            // 
            this.imgLuna.BackColor = System.Drawing.Color.Transparent;
            this.imgLuna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLuna.BackgroundImage")));
            this.imgLuna.Image = ((System.Drawing.Image)(resources.GetObject("imgLuna.Image")));
            this.imgLuna.Location = new System.Drawing.Point(311, 154);
            this.imgLuna.Name = "imgLuna";
            this.imgLuna.Size = new System.Drawing.Size(93, 94);
            this.imgLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLuna.TabIndex = 0;
            this.imgLuna.TabStop = false;
            // 
            // btnDireita
            // 
            this.btnDireita.BackColor = System.Drawing.Color.SlateGray;
            this.btnDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDireita.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDireita.Font = new System.Drawing.Font("Sitka Small", 11.15F, System.Drawing.FontStyle.Bold);
            this.btnDireita.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDireita.Location = new System.Drawing.Point(608, 166);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(96, 82);
            this.btnDireita.TabIndex = 2;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = false;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackColor = System.Drawing.Color.SlateGray;
            this.btnEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEsquerda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEsquerda.Font = new System.Drawing.Font("Sitka Small", 11.15F, System.Drawing.FontStyle.Bold);
            this.btnEsquerda.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEsquerda.Location = new System.Drawing.Point(12, 166);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(96, 82);
            this.btnEsquerda.TabIndex = 3;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = false;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnCima
            // 
            this.btnCima.BackColor = System.Drawing.Color.SlateGray;
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCima.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCima.Font = new System.Drawing.Font("Sitka Small", 11.15F, System.Drawing.FontStyle.Bold);
            this.btnCima.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCima.Location = new System.Drawing.Point(308, 12);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(96, 82);
            this.btnCima.TabIndex = 4;
            this.btnCima.Text = "Cima";
            this.btnCima.UseVisualStyleBackColor = false;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackColor = System.Drawing.Color.SlateGray;
            this.btnBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBaixo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBaixo.Font = new System.Drawing.Font("Sitka Small", 11.15F, System.Drawing.FontStyle.Bold);
            this.btnBaixo.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBaixo.Location = new System.Drawing.Point(305, 336);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(96, 82);
            this.btnBaixo.TabIndex = 5;
            this.btnBaixo.Text = "Baixo";
            this.btnBaixo.UseVisualStyleBackColor = false;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 430);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnCima);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.imgLuna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ache o tesouro";
            ((System.ComponentModel.ISupportInitialize)(this.imgLuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLuna;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
    }
}

