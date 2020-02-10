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
            this.b_quit = new System.Windows.Forms.Button();
            this.PB_Preview_VT = new System.Windows.Forms.PictureBox();
            this.PB_Preview_P3D = new System.Windows.Forms.PictureBox();
            this.Select_Area_VT = new System.Windows.Forms.Button();
            this.Crop_P3D = new System.Windows.Forms.Button();
            this.Crop_VT = new System.Windows.Forms.Button();
            this.Select_Area_P3D = new System.Windows.Forms.Button();
            this.B_ConfMat = new System.Windows.Forms.Button();
            this.LayoutConfMat = new System.Windows.Forms.TableLayoutPanel();
            this.L_TP = new System.Windows.Forms.Label();
            this.L_FN = new System.Windows.Forms.Label();
            this.L_FP = new System.Windows.Forms.Label();
            this.L_TN = new System.Windows.Forms.Label();
            this.TB_TP = new System.Windows.Forms.TextBox();
            this.TB_FP = new System.Windows.Forms.TextBox();
            this.TB_FN = new System.Windows.Forms.TextBox();
            this.TB_TN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMG_P3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview_P3D)).BeginInit();
            this.LayoutConfMat.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Browse_VT
            // 
            this.B_Browse_VT.Location = new System.Drawing.Point(34, 72);
            this.B_Browse_VT.Name = "B_Browse_VT";
            this.B_Browse_VT.Size = new System.Drawing.Size(161, 40);
            this.B_Browse_VT.TabIndex = 0;
            this.B_Browse_VT.Text = "Parcourir...";
            this.B_Browse_VT.UseVisualStyleBackColor = true;
            this.B_Browse_VT.Click += new System.EventHandler(this.B_Browse_VT_Click);
            // 
            // FilePath_B1
            // 
            this.FilePath_B1.BackColor = System.Drawing.Color.White;
            this.FilePath_B1.Enabled = false;
            this.FilePath_B1.Location = new System.Drawing.Point(34, 147);
            this.FilePath_B1.Name = "FilePath_B1";
            this.FilePath_B1.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B1.TabIndex = 1;
            // 
            // FileName_B1
            // 
            this.FileName_B1.BackColor = System.Drawing.Color.White;
            this.FileName_B1.Enabled = false;
            this.FileName_B1.Location = new System.Drawing.Point(201, 72);
            this.FileName_B1.Name = "FileName_B1";
            this.FileName_B1.Size = new System.Drawing.Size(256, 20);
            this.FileName_B1.TabIndex = 1;
            // 
            // B_Browse_P3D
            // 
            this.B_Browse_P3D.Location = new System.Drawing.Point(34, 484);
            this.B_Browse_P3D.Name = "B_Browse_P3D";
            this.B_Browse_P3D.Size = new System.Drawing.Size(161, 40);
            this.B_Browse_P3D.TabIndex = 2;
            this.B_Browse_P3D.Text = "Parcourir...";
            this.B_Browse_P3D.UseVisualStyleBackColor = true;
            this.B_Browse_P3D.Click += new System.EventHandler(this.B_Browse_P3D_Click);
            // 
            // FilePath_B2
            // 
            this.FilePath_B2.BackColor = System.Drawing.Color.White;
            this.FilePath_B2.Enabled = false;
            this.FilePath_B2.Location = new System.Drawing.Point(34, 559);
            this.FilePath_B2.Name = "FilePath_B2";
            this.FilePath_B2.Size = new System.Drawing.Size(423, 20);
            this.FilePath_B2.TabIndex = 3;
            // 
            // FileName_B2
            // 
            this.FileName_B2.BackColor = System.Drawing.Color.White;
            this.FileName_B2.Enabled = false;
            this.FileName_B2.Location = new System.Drawing.Point(201, 484);
            this.FileName_B2.Name = "FileName_B2";
            this.FileName_B2.Size = new System.Drawing.Size(256, 20);
            this.FileName_B2.TabIndex = 3;
            // 
            // PB_IMG_VT
            // 
            this.PB_IMG_VT.BackColor = System.Drawing.Color.White;
            this.PB_IMG_VT.Location = new System.Drawing.Point(488, 72);
            this.PB_IMG_VT.Name = "PB_IMG_VT";
            this.PB_IMG_VT.Size = new System.Drawing.Size(665, 375);
            this.PB_IMG_VT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMG_VT.TabIndex = 4;
            this.PB_IMG_VT.TabStop = false;
            // 
            // PB_IMG_P3D
            // 
            this.PB_IMG_P3D.BackColor = System.Drawing.Color.White;
            this.PB_IMG_P3D.Location = new System.Drawing.Point(488, 484);
            this.PB_IMG_P3D.Name = "PB_IMG_P3D";
            this.PB_IMG_P3D.Size = new System.Drawing.Size(665, 375);
            this.PB_IMG_P3D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMG_P3D.TabIndex = 5;
            this.PB_IMG_P3D.TabStop = false;
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
            this.PB_Preview_VT.Enabled = false;
            this.PB_Preview_VT.Location = new System.Drawing.Point(1199, 72);
            this.PB_Preview_VT.Name = "PB_Preview_VT";
            this.PB_Preview_VT.Size = new System.Drawing.Size(226, 198);
            this.PB_Preview_VT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Preview_VT.TabIndex = 8;
            this.PB_Preview_VT.TabStop = false;
            // 
            // PB_Preview_P3D
            // 
            this.PB_Preview_P3D.BackColor = System.Drawing.Color.ForestGreen;
            this.PB_Preview_P3D.Enabled = false;
            this.PB_Preview_P3D.Location = new System.Drawing.Point(1199, 484);
            this.PB_Preview_P3D.Name = "PB_Preview_P3D";
            this.PB_Preview_P3D.Size = new System.Drawing.Size(226, 198);
            this.PB_Preview_P3D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Preview_P3D.TabIndex = 9;
            this.PB_Preview_P3D.TabStop = false;
            // 
            // Select_Area_VT
            // 
            this.Select_Area_VT.Location = new System.Drawing.Point(1199, 304);
            this.Select_Area_VT.Name = "Select_Area_VT";
            this.Select_Area_VT.Size = new System.Drawing.Size(226, 23);
            this.Select_Area_VT.TabIndex = 10;
            this.Select_Area_VT.Text = "Select Area";
            this.Select_Area_VT.UseVisualStyleBackColor = true;
            this.Select_Area_VT.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Crop_P3D
            // 
            this.Crop_P3D.Location = new System.Drawing.Point(1199, 734);
            this.Crop_P3D.Name = "Crop_P3D";
            this.Crop_P3D.Size = new System.Drawing.Size(226, 23);
            this.Crop_P3D.TabIndex = 11;
            this.Crop_P3D.Text = "Crop Area";
            this.Crop_P3D.UseVisualStyleBackColor = true;
            this.Crop_P3D.Click += new System.EventHandler(this.button4_Click);
            // 
            // Crop_VT
            // 
            this.Crop_VT.Location = new System.Drawing.Point(1199, 333);
            this.Crop_VT.Name = "Crop_VT";
            this.Crop_VT.Size = new System.Drawing.Size(226, 23);
            this.Crop_VT.TabIndex = 12;
            this.Crop_VT.Text = "Crop Area";
            this.Crop_VT.UseVisualStyleBackColor = true;
            this.Crop_VT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Select_Area_P3D
            // 
            this.Select_Area_P3D.Location = new System.Drawing.Point(1199, 705);
            this.Select_Area_P3D.Name = "Select_Area_P3D";
            this.Select_Area_P3D.Size = new System.Drawing.Size(226, 23);
            this.Select_Area_P3D.TabIndex = 13;
            this.Select_Area_P3D.Text = "Select Area";
            this.Select_Area_P3D.UseVisualStyleBackColor = true;
            this.Select_Area_P3D.Click += new System.EventHandler(this.Select_Area_P3D_Click);
            // 
            // B_ConfMat
            // 
            this.B_ConfMat.Location = new System.Drawing.Point(43, 801);
            this.B_ConfMat.Name = "B_ConfMat";
            this.B_ConfMat.Size = new System.Drawing.Size(414, 23);
            this.B_ConfMat.TabIndex = 14;
            this.B_ConfMat.Text = "Matrice de confusion";
            this.B_ConfMat.UseVisualStyleBackColor = true;
            this.B_ConfMat.Click += new System.EventHandler(this.B_ConfMat_Click);
            // 
            // LayoutConfMat
            // 
            this.LayoutConfMat.BackColor = System.Drawing.SystemColors.Control;
            this.LayoutConfMat.ColumnCount = 4;
            this.LayoutConfMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80124F));
            this.LayoutConfMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.8882F));
            this.LayoutConfMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.1118F));
            this.LayoutConfMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.81988F));
            this.LayoutConfMat.Controls.Add(this.L_TP, 0, 0);
            this.LayoutConfMat.Controls.Add(this.L_FN, 0, 1);
            this.LayoutConfMat.Controls.Add(this.L_FP, 2, 0);
            this.LayoutConfMat.Controls.Add(this.L_TN, 2, 1);
            this.LayoutConfMat.Controls.Add(this.TB_TP, 1, 0);
            this.LayoutConfMat.Controls.Add(this.TB_FP, 3, 0);
            this.LayoutConfMat.Controls.Add(this.TB_FN, 1, 1);
            this.LayoutConfMat.Controls.Add(this.TB_TN, 3, 1);
            this.LayoutConfMat.Enabled = false;
            this.LayoutConfMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutConfMat.Location = new System.Drawing.Point(98, 695);
            this.LayoutConfMat.Name = "LayoutConfMat";
            this.LayoutConfMat.RowCount = 2;
            this.LayoutConfMat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutConfMat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutConfMat.Size = new System.Drawing.Size(322, 62);
            this.LayoutConfMat.TabIndex = 15;
            this.LayoutConfMat.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutConfMat_Paint);
            // 
            // L_TP
            // 
            this.L_TP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_TP.AutoSize = true;
            this.L_TP.Enabled = false;
            this.L_TP.Location = new System.Drawing.Point(3, 9);
            this.L_TP.Name = "L_TP";
            this.L_TP.Size = new System.Drawing.Size(31, 13);
            this.L_TP.TabIndex = 0;
            this.L_TP.Text = "TP : ";
            // 
            // L_FN
            // 
            this.L_FN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_FN.AutoSize = true;
            this.L_FN.Enabled = false;
            this.L_FN.Location = new System.Drawing.Point(3, 40);
            this.L_FN.Name = "L_FN";
            this.L_FN.Size = new System.Drawing.Size(31, 13);
            this.L_FN.TabIndex = 2;
            this.L_FN.Text = "FN : ";
            // 
            // L_FP
            // 
            this.L_FP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_FP.AutoSize = true;
            this.L_FP.Enabled = false;
            this.L_FP.Location = new System.Drawing.Point(162, 9);
            this.L_FP.Name = "L_FP";
            this.L_FP.Size = new System.Drawing.Size(30, 13);
            this.L_FP.TabIndex = 1;
            this.L_FP.Text = "FP : ";
            // 
            // L_TN
            // 
            this.L_TN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_TN.AutoSize = true;
            this.L_TN.Enabled = false;
            this.L_TN.Location = new System.Drawing.Point(161, 40);
            this.L_TN.Name = "L_TN";
            this.L_TN.Size = new System.Drawing.Size(32, 13);
            this.L_TN.TabIndex = 3;
            this.L_TN.Text = "TN : ";
            // 
            // TB_TP
            // 
            this.TB_TP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_TP.BackColor = System.Drawing.Color.White;
            this.TB_TP.Enabled = false;
            this.TB_TP.Location = new System.Drawing.Point(47, 5);
            this.TB_TP.Name = "TB_TP";
            this.TB_TP.ReadOnly = true;
            this.TB_TP.Size = new System.Drawing.Size(100, 20);
            this.TB_TP.TabIndex = 4;
            // 
            // TB_FP
            // 
            this.TB_FP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_FP.BackColor = System.Drawing.Color.White;
            this.TB_FP.Enabled = false;
            this.TB_FP.Location = new System.Drawing.Point(209, 5);
            this.TB_FP.Name = "TB_FP";
            this.TB_FP.ReadOnly = true;
            this.TB_FP.Size = new System.Drawing.Size(100, 20);
            this.TB_FP.TabIndex = 5;
            // 
            // TB_FN
            // 
            this.TB_FN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_FN.BackColor = System.Drawing.Color.White;
            this.TB_FN.Enabled = false;
            this.TB_FN.Location = new System.Drawing.Point(47, 36);
            this.TB_FN.Name = "TB_FN";
            this.TB_FN.ReadOnly = true;
            this.TB_FN.Size = new System.Drawing.Size(100, 20);
            this.TB_FN.TabIndex = 6;
            // 
            // TB_TN
            // 
            this.TB_TN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_TN.BackColor = System.Drawing.Color.White;
            this.TB_TN.Enabled = false;
            this.TB_TN.Location = new System.Drawing.Point(209, 36);
            this.TB_TN.Name = "TB_TN";
            this.TB_TN.ReadOnly = true;
            this.TB_TN.Size = new System.Drawing.Size(100, 20);
            this.TB_TN.TabIndex = 7;
            // 
            // Developpe3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 903);
            this.Controls.Add(this.LayoutConfMat);
            this.Controls.Add(this.B_ConfMat);
            this.Controls.Add(this.Select_Area_P3D);
            this.Controls.Add(this.Crop_VT);
            this.Controls.Add(this.Crop_P3D);
            this.Controls.Add(this.Select_Area_VT);
            this.Controls.Add(this.PB_Preview_P3D);
            this.Controls.Add(this.PB_Preview_VT);
            this.Controls.Add(this.b_quit);
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
            this.LayoutConfMat.ResumeLayout(false);
            this.LayoutConfMat.PerformLayout();
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
        private System.Windows.Forms.Button b_quit;
        private System.Windows.Forms.PictureBox PB_Preview_VT;
        private System.Windows.Forms.PictureBox PB_Preview_P3D;
        private System.Windows.Forms.Button Select_Area_VT;
        private System.Windows.Forms.Button Crop_P3D;
        private System.Windows.Forms.Button Crop_VT;
        private System.Windows.Forms.Button Select_Area_P3D;
        private System.Windows.Forms.Button B_ConfMat;
        private System.Windows.Forms.TableLayoutPanel LayoutConfMat;
        private System.Windows.Forms.Label L_TP;
        private System.Windows.Forms.Label L_FP;
        private System.Windows.Forms.Label L_FN;
        private System.Windows.Forms.Label L_TN;
        private System.Windows.Forms.TextBox TB_TP;
        private System.Windows.Forms.TextBox TB_FP;
        private System.Windows.Forms.TextBox TB_FN;
        private System.Windows.Forms.TextBox TB_TN;
    }
}

