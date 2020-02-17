using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developpe3D
{
    public partial class Developpe3D : Form
    {
        public Developpe3D()
        {
            InitializeComponent();
        }



        /*Bouton 1 */
        private void B_Browse_VT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_b1 = new OpenFileDialog();
            ofd_b1.Filter = "All Files|*.*|PNG|*.png|JPEG|*.jpeg";
            if (ofd_b1.ShowDialog() == DialogResult.OK)
            {
                FilePath_B1.Text = ofd_b1.FileName;
                FileName_B1.Text = ofd_b1.SafeFileName;
                PB_IMG_VT.ImageLocation = ofd_b1.FileName;
            }

            Image img_vt = new Bitmap(ofd_b1.FileName);
            PB_IMG_VT.Image = img_vt;


        }


        /*Bouton 2 */
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
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button3_Click_2(object sender, EventArgs e)
        {
            PB_IMG_VT.MouseDown += new MouseEventHandler(PB_MouseDown);
            PB_IMG_VT.MouseMove += new MouseEventHandler(PB_VT_MouseMove);
            PB_IMG_VT.MouseEnter += new EventHandler(PB_MouseEnter);
            Controls.Add(PB_IMG_VT);
        }

        int crpX, crpY, rectW, rectH;

        public Pen crpPen = new Pen(Color.Blue);

        private void PB_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // set initial x,y co ordinates for crop rectangle
                //this is where we firstly click on image
                crpX = e.X;
                crpY = e.Y;

            }
        }   

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

            /*crpImg.Height = PB_Preview_VT.Height;
            crpImg.Width = PB_Preview_VT.Width;*/

            PB_Preview_VT.Image = (Image)crpImg;
            PB_Preview_VT.SizeMode = PictureBoxSizeMode.StretchImage;
        }

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

            PB_Preview_P3D.Image = (Image)crpImg;
            PB_Preview_P3D.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PB_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void PB_VT_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PB_IMG_VT.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = PB_IMG_VT.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void PB_P3D_MouseMove(object sender, MouseEventArgs e)            
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PB_IMG_P3D.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = PB_IMG_P3D.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void Developpe3D_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Select_Area_P3D_Click(object sender, EventArgs e)
        {
            PB_IMG_P3D.MouseDown += new MouseEventHandler(PB_MouseDown);
            PB_IMG_P3D.MouseMove += new MouseEventHandler(PB_P3D_MouseMove);
            PB_IMG_P3D.MouseEnter += new EventHandler(PB_MouseEnter);
            Controls.Add(PB_IMG_P3D);
        }

        private void B_ConfMat_Click(object sender, EventArgs e)
        {
            //variables matrice confusion
            long TP = 0;
            long FN = 0;
            long FP = 0;
            long TN = 0;
            long sum = 0;
            float accuracy = 0;
            float error = 0;

            //variables parcours images
            int px_width = 0;
            int px_height = 0;

            //adaptation de résolution pour les 2 images
            Image VT_img = PB_Preview_VT.Image;
            VT_img = resizeImage(VT_img, new Size(300, 300));
            Bitmap BMP_VT_img = (Bitmap)VT_img;

            Image P3D_img = PB_Preview_P3D.Image;
            P3D_img = resizeImage(P3D_img, new Size(300, 300));
            Bitmap BMP_P3D_img = (Bitmap)P3D_img;         


            //parcours des 2 images et comparaison
            for (px_width = 0; px_width < VT_img.Width; px_width++)
            {
                for (px_height = 0; px_height < VT_img.Height; px_height++)
                {
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



            /* Test de la taille des images
            
            TP = VT_img.Width;
            FP = VT_img.Height;
            FN = P3D_img.Width;
            TN = P3D_img.Height; 

            **********************************/

            TB_TP.Text = TP.ToString();
            TB_FN.Text = FN.ToString();
            TB_FP.Text = FP.ToString();
            TB_TN.Text = TN.ToString();

            sum = TP + FN + FP + TN;
            accuracy = (float)Decimal.Divide((TP + TN), sum);
            error = (float)Decimal.Divide((FP + FN), sum);

            TB_Accuracy.Text = accuracy.ToString();
            TB_Error.Text = error.ToString();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


    }    
}


