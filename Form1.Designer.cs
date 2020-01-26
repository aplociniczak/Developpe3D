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
            this.B_Browse_VT = new System.Windows.Forms.Button();
            this.FilePath_B1 = new System.Windows.Forms.TextBox();
            this.FileName_B1 = new System.Windows.Forms.TextBox();
            this.B_Browse_P3D = new System.Windows.Forms.Button();
            this.FilePath_B2 = new System.Windows.Forms.TextBox();
            this.FileName_B2 = new System.Windows.Forms.TextBox();
            this.PB_IMG_VT = new System.Windows.Forms.PictureBox();
            this.PB_IMG_P3D = new System.Windows.Forms.PictureBox();
            this.Calcul_b1 = new System.Windows.Forms.Button();
            this.Calcul_b2 = new System.Windows.Forms.Button();
            this.b_quit = new System.Windows.Forms.Button();
            this.PB_Preview_VT = new System.Windows.Forms.PictureBox();
            this.PB_Preview_P3D = new System.Windows.Forms.PictureBox();
            this.Select_Area_VT = new System.Windows.Forms.Button();
            this.Crop_P3D = new System.Windows.Forms.Button();
            this.Crop_VT = new System.Windows.Forms.Button();
            this.Select_Area_P3D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_P3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_P3D)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Browse_VT
            // 
            this.B_Browse_VT.Location = new System.Drawing.Point(34, 223);
            this.B_Browse_VT.Name = "B_Browse_VT";
            this.B_Browse_VT.Size = new System.Drawing.Size(161, 40);
            this.B_Browse_VT.TabIndex = 0;
            this.B_Browse_VT.Text = "Parcourir...";
            this.B_Browse_VT.UseVisualStyleBackColor = true;
            this.B_Browse_VT.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilePath_B1
            // 
            this.FilePath_B1.Location = new System.Drawing.Point(34, 269);
            this.FilePath_B1.Name = "FilePath_B1";
            this.FilePath_B1.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B1.TabIndex = 1;
            // 
            // FileName_B1
            // 
            this.FileName_B1.Location = new System.Drawing.Point(201, 223);
            this.FileName_B1.Name = "FileName_B1";
            this.FileName_B1.Size = new System.Drawing.Size(256, 20);
            this.FileName_B1.TabIndex = 1;
            // 
            // B_Browse_P3D
            // 
            this.B_Browse_P3D.Location = new System.Drawing.Point(34, 563);
            this.B_Browse_P3D.Name = "B_Browse_P3D";
            this.B_Browse_P3D.Size = new System.Drawing.Size(161, 40);
            this.B_Browse_P3D.TabIndex = 2;
            this.B_Browse_P3D.Text = "Parcourir...";
            this.B_Browse_P3D.UseVisualStyleBackColor = true;
            this.B_Browse_P3D.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilePath_B2
            // 
            this.FilePath_B2.Location = new System.Drawing.Point(34, 640);
            this.FilePath_B2.Name = "FilePath_B2";
            this.FilePath_B2.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B2.TabIndex = 3;
            // 
            // FileName_B2
            // 
            this.FileName_B2.Location = new System.Drawing.Point(201, 563);
            this.FileName_B2.Name = "FileName_B2";
            this.FileName_B2.Size = new System.Drawing.Size(256, 20);
            this.FileName_B2.TabIndex = 3;
            // 
            // PB_IMG_VT
            // 
            this.PB_IMG_VT.BackColor = System.Drawing.Color.White;
            this.PB_IMG_VT.Location = new System.Drawing.Point(517, 115);
            this.PB_IMG_VT.Name = "PB_IMG_VT";
            this.PB_IMG_VT.Size = new System.Drawing.Size(631, 318);
            this.PB_IMG_VT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMG_VT.TabIndex = 4;
            this.PB_IMG_VT.TabStop = false;
            this.PB_IMG_VT.Click += new System.EventHandler(this.PB_IMG_VT_Click);
            // 
            // PB_IMG_P3D
            // 
            this.PB_IMG_P3D.BackColor = System.Drawing.Color.White;
            this.PB_IMG_P3D.Location = new System.Drawing.Point(517, 491);
            this.PB_IMG_P3D.Name = "PB_IMG_P3D";
            this.PB_IMG_P3D.Size = new System.Drawing.Size(631, 318);
            this.PB_IMG_P3D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMG_P3D.TabIndex = 5;
            this.PB_IMG_P3D.TabStop = false;
            // 
            // Calcul_b1
            // 
            this.Calcul_b1.Location = new System.Drawing.Point(34, 328);
            this.Calcul_b1.Name = "Calcul_b1";
            this.Calcul_b1.Size = new System.Drawing.Size(423, 41);
            this.Calcul_b1.TabIndex = 6;
            this.Calcul_b1.Text = "Calcul_b1";
            this.Calcul_b1.UseVisualStyleBackColor = true;
            this.Calcul_b1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Calcul_b2
            // 
            this.Calcul_b2.Location = new System.Drawing.Point(34, 688);
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
            // PB_Preview_VT
            // 
            this.PB_Preview_VT.BackColor = System.Drawing.Color.ForestGreen;
            this.PB_Preview_VT.Location = new System.Drawing.Point(1199, 115);
            this.PB_Preview_VT.Name = "PB_Preview_VT";
            this.PB_Preview_VT.Size = new System.Drawing.Size(139, 158);
            this.PB_Preview_VT.TabIndex = 8;
            this.PB_Preview_VT.TabStop = false;
            this.PB_Preview_VT.Click += new System.EventHandler(this.preview_VT_Click);
            // 
            // PB_Preview_P3D
            // 
            this.PB_Preview_P3D.BackColor = System.Drawing.Color.ForestGreen;
            this.PB_Preview_P3D.Location = new System.Drawing.Point(1199, 491);
            this.PB_Preview_P3D.Name = "PB_Preview_P3D";
            this.PB_Preview_P3D.Size = new System.Drawing.Size(139, 158);
            this.PB_Preview_P3D.TabIndex = 9;
            this.PB_Preview_P3D.TabStop = false;
            this.PB_Preview_P3D.Click += new System.EventHandler(this.preview_P3D_Click);
            // 
            // Select_Area_VT
            // 
            this.Select_Area_VT.Location = new System.Drawing.Point(1199, 337);
            this.Select_Area_VT.Name = "Select_Area_VT";
            this.Select_Area_VT.Size = new System.Drawing.Size(139, 23);
            this.Select_Area_VT.TabIndex = 10;
            this.Select_Area_VT.Text = "Select Area";
            this.Select_Area_VT.UseVisualStyleBackColor = true;
            this.Select_Area_VT.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Crop_P3D
            // 
            this.Crop_P3D.Location = new System.Drawing.Point(1199, 722);
            this.Crop_P3D.Name = "Crop_P3D";
            this.Crop_P3D.Size = new System.Drawing.Size(139, 23);
            this.Crop_P3D.TabIndex = 11;
            this.Crop_P3D.Text = "Crop Area";
            this.Crop_P3D.UseVisualStyleBackColor = true;
            this.Crop_P3D.Click += new System.EventHandler(this.button4_Click);
            // 
            // Crop_VT
            // 
            this.Crop_VT.Location = new System.Drawing.Point(1199, 366);
            this.Crop_VT.Name = "Crop_VT";
            this.Crop_VT.Size = new System.Drawing.Size(139, 23);
            this.Crop_VT.TabIndex = 12;
            this.Crop_VT.Text = "Crop Area";
            this.Crop_VT.UseVisualStyleBackColor = true;
            this.Crop_VT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Select_Area_P3D
            // 
            this.Select_Area_P3D.Location = new System.Drawing.Point(1199, 688);
            this.Select_Area_P3D.Name = "Select_Area_P3D";
            this.Select_Area_P3D.Size = new System.Drawing.Size(139, 23);
            this.Select_Area_P3D.TabIndex = 13;
            this.Select_Area_P3D.Text = "Select Area";
            this.Select_Area_P3D.UseVisualStyleBackColor = true;
            this.Select_Area_P3D.Click += new System.EventHandler(this.Select_Area_P3D_Click);
            // 
            // Developpe3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 903);
            this.Controls.Add(this.Select_Area_P3D);
            this.Controls.Add(this.Crop_VT);
            this.Controls.Add(this.Crop_P3D);
            this.Controls.Add(this.Select_Area_VT);
            this.Controls.Add(this.PB_Preview_P3D);
            this.Controls.Add(this.PB_Preview_VT);
            this.Controls.Add(this.b_quit);
            this.Controls.Add(this.Calcul_b2);
            this.Controls.Add(this.Calcul_b1);
            this.Controls.Add(this.PB_IMG_P3D);
            this.Controls.Add(this.PB_IMG_VT);
            this.Controls.Add(this.FileName_B2);
            this.Controls.Add(this.FilePath_B2);
            this.Controls.Add(this.B_Browse_P3D);
            this.Controls.Add(this.FileName_B1);
            this.Controls.Add(this.FilePath_B1);
            this.Controls.Add(this.B_Browse_VT);
            this.Name = "Developpe3D";
            this.Text = "Developpe3D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_VT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_P3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_VT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_P3D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Browse_VT;
        private System.Windows.Forms.TextBox FilePath_B1;
        private System.Windows.Forms.TextBox FileName_B1;
        private System.Windows.Forms.Button B_Browse_P3D;
        private System.Windows.Forms.TextBox FilePath_B2;
        private System.Windows.Forms.TextBox FileName_B2;
        private System.Windows.Forms.PictureBox PB_IMG_VT;
        private System.Windows.Forms.PictureBox PB_IMG_P3D;
        private System.Windows.Forms.Button Calcul_b1;
        private System.Windows.Forms.Button Calcul_b2;
        private System.Windows.Forms.Button b_quit;
        private System.Windows.Forms.PictureBox PB_Preview_VT;
        private System.Windows.Forms.PictureBox PB_Preview_P3D;
        private System.Windows.Forms.Button Select_Area_VT;
        private System.Windows.Forms.Button Crop_P3D;
        private System.Windows.Forms.Button Crop_VT;
        private System.Windows.Forms.Button Select_Area_P3D;
    }
}

