using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KMZI_7
{
	class File_manager
	{
		public string Login { get; set; }
		public string Pass { get; set; }
		public string Access { get; set; }
		public bool Flag {get;set;}
		public string Admin { get; set; }
		public File_manager ()
		{
			Admin = "Админ";
			Login = string.Empty;
			Pass = string.Empty;
			Access = string.Empty;
			Flag = true;
		}
		public void Del(string name)
		{
			try
			{
				File.Delete(@"E:\Поляков Максим Сергеевич\KMZI\KMZI_7\KMZI_7\Logs\" + name + ".txt");
			}
			catch (FileNotFoundException)
			{
				//MessageBox.Show("Файл не найден");
				Flag = false;
			}
			catch (IOException)
			{
				//MessageBox.Show("Ошибка чтения файла");
				Flag = false;
			}
		}
		public void Write_Data ()
		{
			try
			{
				FileStream file_output = new FileStream( "Data" + ".txt", FileMode.Create); //создаем файловый поток
				StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
				writer.Write(Login); //записываем в файл
				writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

			}
			catch (Exception) { Flag = false; }
		}
		public string Read_Data()
		{
			try
			{
				FileStream file = new FileStream("Data" + ".txt", FileMode.Open); //создаем файловый поток
				StreamReader reader = new StreamReader(file, Encoding.GetEncoding(1251)); // создаем «потоковый читатель» и связываем его с файловым потоком 
				string str = (reader.ReadToEnd());//считываем все данные с потока и выводим на 
				reader.Close(); //закрываем поток
				return str;
				//File.Delete(@"E:\Поляков Максим Сергеевич\KMZI\KMZI_7\KMZI_7\Logs\" + "Data" + ".txt");

			}
			catch (FileNotFoundException)
			{
				//MessageBox.Show("Файл не найден");
				Flag = false;
				return string.Empty;
			}
			catch (IOException)
			{
				//MessageBox.Show("Ошибка чтения файла");
				Flag = false;
				return string.Empty;
			}
		}

		public void Reader( string name)
		{
			try
			{
				FileStream file = new FileStream(@"E:\Поляков Максим Сергеевич\KMZI\KMZI_7\KMZI_7\Logs\"+name + ".txt", FileMode.Open); //создаем файловый поток
				StreamReader reader = new StreamReader(file, Encoding.GetEncoding(1251)); // создаем «потоковый читатель» и связываем его с файловым потоком 
				Login = (reader.ReadLine());//считываем все данные с потока и выводим на 
				Pass = (reader.ReadLine());
				Access = (reader.ReadLine());
				reader.Close(); //закрываем поток

			}
			catch (FileNotFoundException)
			{
				//MessageBox.Show("Файл не найден");
				Flag = false;
			}
			catch (IOException)
			{
				//MessageBox.Show("Ошибка чтения файла");
				Flag = false;
			}
		}
		
		public void Writer(string name)
		{
			Flag = !(Access == "104410861089109010911087");
			try
			{
				FileStream file_output = new FileStream(@"E:\Поляков Максим Сергеевич\KMZI\KMZI_7\KMZI_7\Logs\" + name + ".txt", FileMode.Create); //создаем файловый поток
				StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
				writer.Write(Login + "\r\n" + Pass + "\r\n" + Access); //записываем в файл
				writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
			}
		catch (Exception) { Flag = false; }
		}
	}
}
