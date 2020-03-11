using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* TODOs : 
 *      1) Adapter le chemin de sauvegarde d'une image
 *      2) Modifier le chemin de sauvegarde de l'image
 *      3) Récupération de la couleur d'un pixel avec la méthode GetPixel
 *      4) Adapter la taille de la fenêtre à plusieurs résolutions (développement effectué sur écran 1440p)
 *      5) Tester plusieurs cas d'utilisation pour déceler des bugs dans le code
 *      6) Sélectionner une zone d'une image de bas en haut
 */


namespace Developpe3D
{
    public partial class Developpe3D : Form
    {
        public Developpe3D()
        {
            InitializeComponent();
        }



        /* Bouton Parcourir - Vérité Terrain */
        private void B_Browse_VT_Click(object sender, EventArgs e)
        {
            /* Création fenêtre de dialogue*/
            OpenFileDialog ofd_b1 = new OpenFileDialog();
            /* Fichiers ouvrables par la fenêtre */
            ofd_b1.Filter = "All Files|*.*|PNG|*.png|JPEG|*.jpeg";
            if (ofd_b1.ShowDialog() == DialogResult.OK)
            {
                /* Récupération du nom du fichier pour affichage */
                FilePath_B1.Text = ofd_b1.FileName; 
                FileName_B1.Text = ofd_b1.SafeFileName;
                /* Récupération du chemin du fichier pour affichage */
                PB_IMG_VT.ImageLocation = ofd_b1.FileName;
            }

            /* Stockage de l'image dans un objet Image */
            Image img_vt = new Bitmap(ofd_b1.FileName);
            PB_IMG_VT.Image = img_vt;

        }


        /* Bouton Parcourir - Projeté 3D */
        private void B_Browse_P3D_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_b2 = new OpenFileDialog();
            ofd_b2.Filter = "All Files|*.*|PNG|*.png|JPEG|*.jpeg";
            if (ofd_b2.ShowDialog() == DialogResult.OK)
            {
                FilePath_B2.Text = ofd_b2.FileName;
                FileName_B2.Text = ofd_b2.SafeFileName;
                PB_IMG_P3D.ImageLocation = ofd_b2.FileName;
            }

            Image img_p3d = new Bitmap(ofd_b2.FileName);
            PB_IMG_P3D.Image = img_p3d;
        }

        /* Bouton Quitter */
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        /* Bouton Select Area - Vérité Terrain */
        private void button3_Click_2(object sender, EventArgs e)
        {
            PB_IMG_VT.MouseDown += new MouseEventHandler(PB_MouseDown);
            PB_IMG_VT.MouseMove += new MouseEventHandler(PB_VT_MouseMove);
            PB_IMG_VT.MouseEnter += new EventHandler(PB_MouseEnter);
            Controls.Add(PB_IMG_VT);
        }

        /* Variables de sélection */
        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.Blue);

        /* Fonction de gestion du curseur vers le bas 
         * Attention de bien sélectionner la zone de haut en bas 
         * La gestion de haut en bas n'est pas encore traitée   */
        private void PB_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                /* set initial x,y coordinates for crop rectangle
                *  this is where we firstly click on image */
                crpX = e.X;
                crpY = e.Y;

            }
        }   

        /* Fonction pour exploiter la zone sélectionnée - Vérité Terrain */
        private void Crop_VT_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Bitmap bmp2 = new Bitmap(PB_IMG_VT.Width, PB_IMG_VT.Height);
            PB_IMG_VT.DrawToBitmap(bmp2, PB_IMG_VT.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            /* Affichage de l'image "croppée" dans la PictureBox PB_Preview_VT */
            PB_Preview_VT.Image = (Image)crpImg;
            PB_Preview_VT.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /* Fonction pour exploiter la zone sélectionnée - Projeté 3D */
        private void Crop_P3D_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Bitmap bmp3 = new Bitmap(PB_IMG_P3D.Width, PB_IMG_P3D.Height);
            PB_IMG_P3D.DrawToBitmap(bmp3, PB_IMG_P3D.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);


            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp3.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            /* Affichage de l'image "croppée" dans la PictureBox PB_Preview_P3D */
            PB_Preview_P3D.Image = (Image)crpImg;
            PB_Preview_P3D.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        private void PB_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        /* Gestion du mouvement du curseur pour la sélection de la zone - Vérité Terrain */
        private void PB_VT_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PB_IMG_VT.Refresh();
                /* set width and height for crop rectangle. */
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = PB_IMG_VT.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        /* Gestion du mouvement du curseur pour la sélection de la zone - Projeté 3D */
        private void PB_P3D_MouseMove(object sender, MouseEventArgs e)            
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PB_IMG_P3D.Refresh();
                /* set width and height for crop rectangle. */
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = PB_IMG_P3D.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        /* Cliquer sur la fenêtre de Développé remet le curseur par défaut */ 
        private void Developpe3D_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        /* Bouton de sauvegarde du résultat de la fenêtre
         * En l'état : fait une capture d'écran de la fenêtre */
        private void B_Save_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                /* TODO 1) : adapter le chemin de sauvegarde d'une image */
                bitmap.Save(@"D:\Dropbox\Dropbox\Polytech\5A\PFE\Code\Developpe3D\Captures\Capture_"+ DateTime.Now.ToFileTime() + ".png", ImageFormat.Png);

                /* Bout de code utile pour le chemin de sauvegarde  
                 * bitmap.Save(Directory.GetCurrentDirectory()+"Capture"+ DateTime.Now.ToFileTime() + ".png", ImageFormat.Png); */
            }

            /* TODO 2) : modifier le chemin de sauvegarde de l'image */
            MessageBox.Show("Image sauvegardée dans D:/Dropbox/Dropbox/Polytech/5A/PFE/Code/Developpe3D/Captures");
        }

        /* Bouton Select Area - Projeté 3D */
        private void Select_Area_P3D_Click(object sender, EventArgs e)
        {
            PB_IMG_P3D.MouseDown += new MouseEventHandler(PB_MouseDown);
            PB_IMG_P3D.MouseMove += new MouseEventHandler(PB_P3D_MouseMove);
            PB_IMG_P3D.MouseEnter += new EventHandler(PB_MouseEnter);
            Controls.Add(PB_IMG_P3D);
        }

        private void B_ConfMat_Click(object sender, EventArgs e)
        {
            /* variables matrice confusion */
            long TP = 0;
            long FN = 0;
            long FP = 0;
            long TN = 0;
            long sum = 0;
            float accuracy = 0;
            float error = 0;

            /* variables parcours images */
            int px_width = 0;
            int px_height = 0;

            /* adaptation de résolution pour les 2 images */
            Image VT_img = PB_Preview_VT.Image;
            VT_img = resizeImage(VT_img, new Size(300, 300));
            Bitmap BMP_VT_img = (Bitmap)VT_img;

            Image P3D_img = PB_Preview_P3D.Image;
            P3D_img = resizeImage(P3D_img, new Size(300, 300));
            Bitmap BMP_P3D_img = (Bitmap)P3D_img;         


            /* parcours des 2 images et comparaison */
            for (px_width = 0; px_width < VT_img.Width; px_width++)
            {
                for (px_height = 0; px_height < VT_img.Height; px_height++)
                {
                    /* TODO 3) : récupération de la couleur d'un pixel avec la méthode GetPixel */ 
                    //TEST
                    /*if (BMP_VT_img.GetPixel(px_width, px_height).R==255 && BMP_VT_img.GetPixel(px_width, px_height).G == 255 && BMP_VT_img.GetPixel(px_width, px_height).B == 255)
                    {
                        TP++;
                    }

                    else
                    {
                        FN++;
                    }*/

                    //BLANC (255x3) - BLANC (255x3)
                    //if (BMP_VT_img.GetPixel(px_width, px_height) == Color.White && BMP_P3D_img.GetPixel(px_width, px_height) == Color.White)
                    
                    /* La couleur des pixels sont ici récupérées avec les compostantes RGB 
                     * Fastidieux pour faire évoluer le parcours */
                    if (BMP_VT_img.GetPixel(px_width, px_height).R == 255 && BMP_VT_img.GetPixel(px_width, px_height).G == 255 && BMP_VT_img.GetPixel(px_width, px_height).B == 255 && BMP_P3D_img.GetPixel(px_width, px_height).R == 255 && BMP_P3D_img.GetPixel(px_width, px_height).G == 255 && BMP_P3D_img.GetPixel(px_width, px_height).B == 255)
                    {
                        TP++;
                    }

                    //BLANC (255x3) - NOIR (0x3)
                    //else if(BMP_VT_img.GetPixel(px_width, px_height) == Color.White && BMP_P3D_img.GetPixel(px_width, px_height) == Color.Black)

                    else if (BMP_VT_img.GetPixel(px_width, px_height).R == 255 && BMP_VT_img.GetPixel(px_width, px_height).G == 255 && BMP_VT_img.GetPixel(px_width, px_height).B == 255 && BMP_P3D_img.GetPixel(px_width, px_height).R == 0 && BMP_P3D_img.GetPixel(px_width, px_height).G == 0 && BMP_P3D_img.GetPixel(px_width, px_height).B == 0)
                    {
                        FN++;
                    }

                    //NOIR (0x3) -BLANC (255x3)
                    //else if (BMP_VT_img.GetPixel(px_width, px_height) == Color.Black && BMP_P3D_img.GetPixel(px_width, px_height) == Color.White)

                    else if (BMP_VT_img.GetPixel(px_width, px_height).R == 0 && BMP_VT_img.GetPixel(px_width, px_height).G == 0 && BMP_VT_img.GetPixel(px_width, px_height).B == 0 && BMP_P3D_img.GetPixel(px_width, px_height).R == 255 && BMP_P3D_img.GetPixel(px_width, px_height).G == 255 && BMP_P3D_img.GetPixel(px_width, px_height).B == 255)
                    {
                        FP++;
                    }

                    //NOIR (0x3) - NOIR (0x3)                    
                    //else if (BMP_VT_img.GetPixel(px_width, px_height) == Color.Black && BMP_P3D_img.GetPixel(px_width, px_height) == Color.Black)

                    else if (BMP_VT_img.GetPixel(px_width, px_height).R == 0 && BMP_VT_img.GetPixel(px_width, px_height).G == 0 && BMP_VT_img.GetPixel(px_width, px_height).B == 0 && BMP_P3D_img.GetPixel(px_width, px_height).R == 0 && BMP_P3D_img.GetPixel(px_width, px_height).G == 0 && BMP_P3D_img.GetPixel(px_width, px_height).B == 0)
                    {
                        TN++;
                    }
                }
            }   


            /* Affichage des TP, FN, FP et TN*/ 
            TB_TP.Text = TP.ToString();
            TB_FN.Text = FN.ToString();
            TB_FP.Text = FP.ToString();
            TB_TN.Text = TN.ToString();

            /* Opérations termes - éléments d'évaluation de la similitude entre 2 images */ 
            sum = TP + FN + FP + TN;
            accuracy = (float)Decimal.Divide((TP + TN), sum);
            error = (float)Decimal.Divide((FP + FN), sum);

            /* Affichage de la précision et du taux d'erreur */
            TB_Accuracy.Text = accuracy.ToString();
            TB_Error.Text = error.ToString();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


    }    
}


