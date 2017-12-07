using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КМЗИ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shifr shifr = new Shifr();
        Ras ras = new Ras();

        private void Shifr_Click(object sender, EventArgs e)
        {

            Bitmap bit = null;
            OpenFileDialog fb = new OpenFileDialog();
            fb.FilterIndex = 1;
            fb.Filter = "jpg|*.jpg";


            if (fb.ShowDialog() == DialogResult.OK)
            {

                bit = (Bitmap)Image.FromFile(fb.FileName);
            }

            shifr.run(bit);

            MessageBox.Show("Сделано");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bit = null;
            OpenFileDialog fb = new OpenFileDialog();
            fb.FilterIndex = 1;
            fb.Filter = "jpg|*.jpg";


            if (fb.ShowDialog() == DialogResult.OK)
            {

                bit = (Bitmap)Image.FromFile(fb.FileName);
            }

            ras.run(bit);


            MessageBox.Show("Сделано");
        }
    }
}
