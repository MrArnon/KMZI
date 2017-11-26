using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace KMZI_2
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }
        private void Еncryption_button_Click(object sender, EventArgs e)
        {
			Liter liter = new Liter();
			string info = Insert_text_box.Text;

			Shifr_text.Text = liter.Encript(info);
            FileStream file_output = new FileStream("output.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(Shifr_text.Text); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Shifr_text.Text = Insert_text_box.Text = string.Empty;
        }

        private void Transcript_button_Click(object sender, EventArgs e)
        {
			Liter liter = new Liter();
			string info = Insert_text_box.Text;
        
            Shifr_text.Text = liter.Transcript(info);
            FileStream file_output = new FileStream("output.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(Shifr_text.Text); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

        }

        private void File_button_Click(object sender, EventArgs e)
        {


            try
            {
                FileStream file_input = new FileStream("input.txt", FileMode.Open); //создаем файловый поток
                StreamReader reader = new StreamReader(file_input, Encoding.GetEncoding(1251)); // создаем «потоковый читатель» и связываем его с файловым потоком 
                Insert_text_box.Text = (reader.ReadToEnd());  //считываем все данные с потока и выводим на 
                reader.Close(); //закрываем поток
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден");
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка чтения файла");
            }
        }
    }
}
