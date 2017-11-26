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
using System.Diagnostics;

namespace KMZI_6
{
	public partial class Testing : Form
	{
		public Testing()
		{
			InitializeComponent();
		}
		Reader reader = new Reader();
		Check_test check_Test = new Check_test();
		const int kol_liter = 64;//32+32 буквы русского алфавита большие и маленькие (без букв Ё ё )
		private void But_Start_Click(object sender, EventArgs e)
		{
			Text_answer.Visible = true;
			But_answer.Visible = true;
			reader = new Reader(Convert.ToString(check_Test.Counter), Convert.ToString(check_Test.Counter));
			Text_output.Text = reader.Question;
			But_Start.Visible = false;
			But_demon.Visible = false;
			Text_shifr.Visible = false;
			But_decript.Visible = false;
			But_theory.Visible = false;
		}

		private void But_answer_Click(object sender, EventArgs e)
		{
			if(check_Test.Numbers_que==check_Test.Counter)
			{
				MessageBox.Show("Верных ответов - " + check_Test.Right_answer , "Конец тестирования");
				//Text_output.Text = "Вы правильно ответили на " + check_Test.Right_answer + " вопросов" + "\r\n" + "Для продолжения нажмите кнопку продолжить";
				Text_answer.Visible = false;
				But_answer.Visible = false;
				But_Start.Visible = true;
				But_demon.Visible = true;
				But_theory.Visible = true;
				But_decript.Visible = true;
				Text_shifr.Visible = true;
				Text_output.Text= "Для начала тестирования нажмите кнопку Начать"+ "\r\n"+ "Ответы вводить на русском языке" +"\r\n"+"Для шифрования введите текст и нажмите кнопку Шифр"+"\r\n"+"Для расшифровки нажмите кнопку Расшифр";
			}

			else
			{
				if(!string.IsNullOrWhiteSpace(Text_answer.Text))
				{
					check_Test.Answer = Text_answer.Text;
					reader = new Reader(Convert.ToString(check_Test.Counter), Convert.ToString(check_Test.Counter));
					check_Test.Control(reader.Answer);
					Text_answer.Text = string.Empty;
				}
				else
				{
					MessageBox.Show("Вы ввели пустую строку !", "Повторите ввод");
					Text_answer.Text = string.Empty;
				}
				reader = new Reader(Convert.ToString(check_Test.Counter), Convert.ToString(check_Test.Counter));
				if (reader.Question == "Для продолжения нажмите кнопку Ответить") Text_answer.Visible = false; 
				Text_output.Text = reader.Question;
			}

		}

		private void But_demon_Click(object sender, EventArgs e)
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
			//string info = Insert_text_box.Text;
			string info = Text_shifr.Text;
			string new_info = string.Empty;
			for (int i = 0; i < info.Length; i++)
			{
				char bukva = info[i];
				int p = 0;
				bool b = false;
				while (p < spisok.Count && !b)
				{
					Liter temp = spisok[p];
					b = bukva == temp.lit;
					if (b)
					{
						int conv = temp.Pop(temp.count);
						new_info += conv.ToString();
						temp.count++;
						temp.Control();
					}
					spisok[p] = temp;
					p++;
				}
			}
			spisok.Clear();
			//Shifr_text.Text = new_info;
			Text_output.Text = "Для начала тестирования нажмите кнопку Начать" + "\r\n" + "Ответы вводить на русском языке" + "\r\n" + "Для шифрования введите текст и нажмите кнопку Шифр"+ "\r\n"+"Для расшифровки нажмите кнопку Расшифр"+"\r\n" + "Зашифрованная строка"+ "\r\n" + new_info;
			FileStream file_output = new FileStream("cript_text.txt", FileMode.Create); //создаем файловый поток
			StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
			writer.Write(new_info); //записываем в файл
			writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

		}

		private void But_decript_Click(object sender, EventArgs e)
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
			//string info = Insert_text_box.Text;
			string info = Text_shifr.Text;
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
					catch (Exception) { MessageBox.Show("Неверно введенные данные"); }
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
			//Shifr_text.Text = new_info;
			Text_output.Text = "Для начала тестирования нажмите кнопку Начать" + "\r\n" + "Ответы вводить на русском языке" + "\r\n" + "Для шифрования введите текст и нажмите кнопку Шифр" + "\r\n"+"Для расшифровки нажмите кнопку Расшифр" + "\r\n" + "Расшифрованная строка" + "\r\n" + new_info;
			FileStream file_output = new FileStream("decript_text.txt", FileMode.Create); //создаем файловый поток
			StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
			writer.Write(new_info); //записываем в файл
			writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
		}

		private void But_theory_Click(object sender, EventArgs e)
		{
			Process.Start("E:\\Labs\\KMZI_6\\KMZI_6\\bin\\Debug\\theory.txt");
		}
	}
}
