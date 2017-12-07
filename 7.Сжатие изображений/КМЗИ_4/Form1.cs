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

        Encript shifr = new Encript();
        Decript ras = new Decript();

        private void Shifr_Click(object sender, EventArgs e)
        {
			long G = Convert.ToInt64(Numeric_value.Value);
			if ((G <= 100 && G >= 0))
			{
				Bitmap bit = null;
				OpenFileDialog fb = new OpenFileDialog();
				fb.FilterIndex = 1;
				fb.Filter = "jpg|*.jpg";


				if (fb.ShowDialog() == DialogResult.OK)
				{

					bit = (Bitmap)Image.FromFile(fb.FileName);
				}

				shifr.run(bit, G);

				MessageBox.Show("Зашифровано", "Готово");
			}
			else
			{ MessageBox.Show("Введите значение от 0 до 100"); Numeric_value.Value = 10; }
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
			long G = Convert.ToInt64(Numeric_value.Value);
			if ((G <= 100 && G >= 0))
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


				MessageBox.Show("Расшифровано", "Готово");
			}
			else
			{ MessageBox.Show("Введите значение от 0 до 100"); Numeric_value.Value = 10; }
	
			}
    }
}
