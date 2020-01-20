namespace Developpe3D
{
    partial class Developpe3D
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.FilePath_B1 = new System.Windows.Forms.TextBox();
            this.FileName_B1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FilePath_B2 = new System.Windows.Forms.TextBox();
            this.FileName_B2 = new System.Windows.Forms.TextBox();
            this.Img_VT = new System.Windows.Forms.PictureBox();
            this.Img_P3D = new System.Windows.Forms.PictureBox();
            this.Calcul_b1 = new System.Windows.Forms.Button();
            this.Calcul_b2 = new System.Windows.Forms.Button();
            this.b_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_P3D)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parcourir...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilePath_B1
            // 
            this.FilePath_B1.Location = new System.Drawing.Point(120, 279);
            this.FilePath_B1.Name = "FilePath_B1";
            this.FilePath_B1.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B1.TabIndex = 1;
            // 
            // FileName_B1
            // 
            this.FileName_B1.Location = new System.Drawing.Point(287, 233);
            this.FileName_B1.Name = "FileName_B1";
            this.FileName_B1.Size = new System.Drawing.Size(256, 20);
            this.FileName_B1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parcourir...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilePath_B2
            // 
            this.FilePath_B2.Location = new System.Drawing.Point(120, 650);
            this.FilePath_B2.Name = "FilePath_B2";
            this.FilePath_B2.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B2.TabIndex = 3;
            // 
            // FileName_B2
            // 
            this.FileName_B2.Location = new System.Drawing.Point(287, 593);
            this.FileName_B2.Name = "FileName_B2";
            this.FileName_B2.Size = new System.Drawing.Size(256, 20);
            this.FileName_B2.TabIndex = 3;
            // 
            // Img_VT
            // 
            this.Img_VT.Location = new System.Drawing.Point(684, 105);
            this.Img_VT.Name = "Img_VT";
            this.Img_VT.Size = new System.Drawing.Size(631, 318);
            this.Img_VT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_VT.TabIndex = 4;
            this.Img_VT.TabStop = false;
            // 
            // Img_P3D
            // 
            this.Img_P3D.Location = new System.Drawing.Point(684, 476);
            this.Img_P3D.Name = "Img_P3D";
            this.Img_P3D.Size = new System.Drawing.Size(631, 318);
            this.Img_P3D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_P3D.TabIndex = 5;
            this.Img_P3D.TabStop = false;
            // 
            // Calcul_b1
            // 
            this.Calcul_b1.Location = new System.Drawing.Point(120, 338);
            this.Calcul_b1.Name = "Calcul_b1";
            this.Calcul_b1.Size = new System.Drawing.Size(423, 41);
            this.Calcul_b1.TabIndex = 6;
            this.Calcul_b1.Text = "Calcul_b1";
            this.Calcul_b1.UseVisualStyleBackColor = true;
            this.Calcul_b1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Calcul_b2
            // 
            this.Calcul_b2.Location = new System.Drawing.Point(120, 698);
            this.Calcul_b2.Name = "Calcul_b2";
            this.Calcul_b2.Size = new System.Drawing.Size(423, 41);
            this.Calcul_b2.TabIndex = 6;
            this.Calcul_b2.Text = "Calcul_b2";
            this.Calcul_b2.UseVisualStyleBackColor = true;
            this.Calcul_b2.Click += new System.EventHandler(this.Calcul_b2_Click);
            // 
            // b_quit
            // 
            this.b_quit.Location = new System.Drawing.Point(1319, 857);
            this.b_quit.Name = "b_quit";
            this.b_quit.Size = new System.Drawing.Size(106, 23);
            this.b_quit.TabIndex = 7;
            this.b_quit.Text = "Quitter";
            this.b_quit.UseVisualStyleBackColor = true;
            this.b_quit.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Developpe3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 903);
            this.Controls.Add(this.b_quit);
            this.Controls.Add(this.Calcul_b2);
            this.Controls.Add(this.Calcul_b1);
            this.Controls.Add(this.Img_P3D);
            this.Controls.Add(this.Img_VT);
            this.Controls.Add(this.FileName_B2);
            this.Controls.Add(this.FilePath_B2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileName_B1);
            this.Controls.Add(this.FilePath_B1);
            this.Controls.Add(this.button1);
            this.Name = "Developpe3D";
            this.Text = "Developpe3D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_VT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_P3D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FilePath_B1;
        private System.Windows.Forms.TextBox FileName_B1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FilePath_B2;
        private System.Windows.Forms.TextBox FileName_B2;
        private System.Windows.Forms.PictureBox Img_VT;
        private System.Windows.Forms.PictureBox Img_P3D;
        private System.Windows.Forms.Button Calcul_b1;
        private System.Windows.Forms.Button Calcul_b2;
        private System.Windows.Forms.Button b_quit;
    }
}

