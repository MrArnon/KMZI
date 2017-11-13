using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KMZI_6
{
	class Reader
	{
		public string Question { get; set; }
		public string Answer { get; set; }
		public Reader()
		{
			Question = string.Empty;
			Answer = string.Empty;
		}
		public Reader(string str_q,string str_a)
		{
			try
			{
				FileStream file__q = new FileStream("Q_"+str_q+".txt", FileMode.Open); //создаем файловый поток
				StreamReader reader_q = new StreamReader(file__q, Encoding.GetEncoding(1251)); // создаем «потоковый читатель» и связываем его с файловым потоком 
				Question = (reader_q.ReadToEnd());  //считываем все данные с потока и выводим на 
				reader_q.Close(); //закрываем поток

				FileStream file__a = new FileStream("A_" + str_a + ".txt", FileMode.Open); //создаем файловый поток
				StreamReader reader_a = new StreamReader(file__a, Encoding.GetEncoding(1251)); // создаем «потоковый читатель» и связываем его с файловым потоком 
				Answer = (reader_a.ReadToEnd());  //считываем все данные с потока и выводим на 
				reader_a.Close(); //закрываем поток
			}
			catch (FileNotFoundException)
			{
				//MessageBox.Show("Файл не найден");
			}
			catch (IOException)
			{
				MessageBox.Show("Ошибка чтения файла");
			}
		}
	}
}
