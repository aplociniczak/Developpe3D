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
            ofd_b2.Filter = "PNG|*.png|JPEG|*.jpeg";
            if (ofd_b2.ShowDialog() == DialogResult.OK)
            {
                FilePath_B2.Text = ofd_b2.FileName;
                FileName_B2.Text = ofd_b2.SafeFileName;
                PB_IMG_P3D.ImageLocation = ofd_b2.FileName;
            }

            Image img_p3d = new Bitmap(ofd_b2.FileName);
            PB_IMG_P3D.Image = img_p3d;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
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

            PB_Preview_VT.Image = (Image)crpImg;
            PB_Preview_VT.SizeMode = PictureBoxSizeMode.StretchImage;
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

        

        private void Select_Area_P3D_Click(object sender, EventArgs e)
        {
            PB_IMG_P3D.MouseDown += new MouseEventHandler(PB_MouseDown);
            PB_IMG_P3D.MouseMove += new MouseEventHandler(PB_P3D_MouseMove);
            PB_IMG_P3D.MouseEnter += new EventHandler(PB_MouseEnter);
            Controls.Add(PB_IMG_P3D);
        }

         private void LayoutConfMat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_ConfMat_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
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
    }
}
