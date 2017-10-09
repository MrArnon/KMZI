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
        const int kol_liter = 64;//32+32 буквы русского алфавита большие и маленькие (без букв Ё ё )
        private void Еncryption_button_Click(object sender, EventArgs e)
        {
            List<Liter> spisok = new List<Liter>();
            int j = 1040;//большая буква А=192 русская в Unicode А=1040 - 1103
            for (int i = 0; i < kol_liter; i++)
            {
                Liter temp = new Liter(j);
                spisok.Add(temp);
                j++;
            }
            // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?'    13 - 'Enter'
            Liter temp1 = new Liter(32);
            spisok.Add(temp1);
            Liter temp2 = new Liter(33);
            spisok.Add(temp2);
            Liter temp3 = new Liter(44);
            spisok.Add(temp3);
            Liter temp4 = new Liter(46);
            spisok.Add(temp4);
            Liter temp5 = new Liter(63);
            spisok.Add(temp5);
            Liter temp6 = new Liter(13);
            spisok.Add(temp6);
            string info = Insert_text_box.Text;
            string new_info=string.Empty;
            for (int i=0;i<info.Length;i++)
            {
                char bukva = info[i];
                int p = 0;
                bool b = false;
                while (p<spisok.Count && !b)
                {
                    Liter temp = spisok[p];
                    b = bukva == temp.lit;
                    if (b) {
                        int conv = temp.Pop(temp.count);
                        new_info += conv.ToString();
                        temp.count++;
                        temp.Control(); }
                    spisok[p] = temp;
                    p++;
                }
            }
            spisok.Clear();
            Shifr_text.Text = new_info;
            FileStream file_output = new FileStream("output.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(new_info); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Shifr_text.Text = Insert_text_box.Text = string.Empty;
        }

        private void Transcript_button_Click(object sender, EventArgs e)
        {
            const int n_mas = 4;
            List<Liter> spisok = new List<Liter>();
            int j = 1040;//большая буква А=192 русская в Unicode А=1040 - 1103
            for (int i = 0; i < kol_liter; i++)
            {
                Liter temp = new Liter(j);
                spisok.Add(temp);
                j++;
            }
            Liter temp1 = new Liter(32);
            spisok.Add(temp1);
            Liter temp2 = new Liter(33);
            spisok.Add(temp2);
            Liter temp3 = new Liter(44);
            spisok.Add(temp3);
            Liter temp4 = new Liter(46);
            spisok.Add(temp4);
            Liter temp5 = new Liter(63);
            spisok.Add(temp5);
            Liter temp6 = new Liter(13);
            spisok.Add(temp6);
            string info = Insert_text_box.Text;
            string new_info = string.Empty;
            for (int i = 0; i < info.Length; i++)
            {
                string bukva = string.Empty;
                for (int k = 0; k < n_mas; k++)
                {
                    
                    try
                    {
                        bukva += info[i];
                    }
                    catch(Exception) { MessageBox.Show("Неверно введенные данные"); }
                    i++;
                }
                i--;//костыль
                int p = 0;
                bool b = false;
                while (p < spisok.Count && !b)
                {
                    Liter temp = spisok[p];
                    string str = temp.Pop(temp.count).ToString();
                    if (str == "9999" || str == "9898" || str == "9779" || str == "9000")
                    {
                        new_info += "\r\n";
                        temp.count++;
                        temp.Control();
                    }
                    else
                    {
                        b = bukva == str;
                        if (b)
                        {
                            new_info += temp.lit;
                            temp.count++;
                            temp.Control();
                        }
                    }
                        spisok[p] = temp;
                    p++;
                }
            }
            spisok.Clear();
            Shifr_text.Text = new_info;
            FileStream file_output = new FileStream("output.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(new_info); //записываем в файл
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
