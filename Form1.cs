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
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_b1 = new OpenFileDialog();
            ofd_b1.Filter = "PNG|*.png|JPEG|*.jpeg";
            if (ofd_b1.ShowDialog() == DialogResult.OK)
            {                
                FilePath_B1.Text = ofd_b1.FileName;
                FileName_B1.Text = ofd_b1.SafeFileName;
                Img_VT.ImageLocation = ofd_b1.FileName;
            }


        }


        /*Bouton 2 */
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_b2 = new OpenFileDialog();
            ofd_b2.Filter = "PNG|*.png|JPEG|*.jpeg";
            if (ofd_b2.ShowDialog() == DialogResult.OK)
            {
                FilePath_B2.Text = ofd_b2.FileName;
                FileName_B2.Text = ofd_b2.SafeFileName;
                Img_P3D.ImageLocation = ofd_b2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Calcul_b2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
