namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.labPontuacao = new System.Windows.Forms.Label();
            this.labPontos = new System.Windows.Forms.Label();
            this.timerjogos = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.ForestGreen;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Location = new System.Drawing.Point(12, 84);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(437, 421);
            this.panelPrincipal.TabIndex = 0;
            // 
            // labPontuacao
            // 
            this.labPontuacao.AutoSize = true;
            this.labPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.labPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPontuacao.ForeColor = System.Drawing.Color.Red;
            this.labPontuacao.Location = new System.Drawing.Point(188, 62);
            this.labPontuacao.Name = "labPontuacao";
            this.labPontuacao.Size = new System.Drawing.Size(85, 16);
            this.labPontuacao.TabIndex = 1;
            this.labPontuacao.Text = "Pontuação:";
            // 
            // labPontos
            // 
            this.labPontos.AutoSize = true;
            this.labPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPontos.ForeColor = System.Drawing.Color.Red;
            this.labPontos.Location = new System.Drawing.Point(290, 62);
            this.labPontos.Name = "labPontos";
            this.labPontos.Size = new System.Drawing.Size(15, 16);
            this.labPontos.TabIndex = 2;
            this.labPontos.Text = "0";
            // 
            // timerjogos
            // 
            this.timerjogos.Tick += new System.EventHandler(this.Timerjogos_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Snake.Properties.Resources.Play__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(461, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labPontos);
            this.Controls.Add(this.labPontuacao);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labPontuacao;
        private System.Windows.Forms.Label labPontos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerjogos;
    }
}

