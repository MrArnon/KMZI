using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
namespace KMZI_7
{
	class Games
	{
		public int n {get;set;}
		public string [] Spisok { get; set; }
		public Games()
		{
			n = 6;
			Spisok = new string[n];
			Spisok[0] = "Шифр перестановкой";
			Spisok[1] = "Шифр заменой";
			Spisok[2] = "Шифр Хаффмана";
			Spisok[3] = "Идентификация";
			Spisok[4] = "Простые числа";
			Spisok[5] = "Крестики нолики";
		}
		public void Starting (string ch,string str)
		{
			switch(ch)
			{
				case "Ю": {
						switch (str)
						{
							case "Шифр заменой": { Process.Start("KMZI_1.exe"); break; }
							case "Шифр перестановкой": { Process.Start("KMZI_2.exe"); break; }
							case "Шифр Хаффмана": { Process.Start("Huffman.exe"); break; }
							case "Идентификация": { Process.Start("KMZI_4(password).exe"); break; }
							case "Простые числа": { Process.Start("KMZI_5.exe"); break; }
							case "Крестики нолики": { Process.Start("креститки нолики.exe"); break; }

						}
						break; }
				case "А":
					{
						switch (str)
						{
							case "Шифр заменой": { Process.Start("KMZI_1.exe"); break; }
							case "Шифр перестановкой": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Шифр Хаффмана": { Process.Start("Huffman.exe"); break; }
							case "Идентификация": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Простые числа": { Process.Start("KMZI_5.exe"); break; }
							case "Крестики нолики": { Process.Start("креститки нолики.exe"); break; }

						}
						break;
					}
				case "Б":
					{
						switch (str)
						{
							case "Шифр заменой": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Шифр перестановкой": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Шифр Хаффмана": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Идентификация": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Простые числа": { Process.Start("KMZI_5.exe"); break; }
							case "Крестики нолики": { Process.Start("креститки нолики.exe"); break; }

						}
						break;
					}
				case "В":
					{
						switch (str)
						{
							case "Шифр заменой": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Шифр перестановкой": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Шифр Хаффмана": { MessageBox.Show("Недостаточно прав доступа"); ; break; }
							case "Идентификация": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Простые числа": { MessageBox.Show("Недостаточно прав доступа"); break; }
							case "Крестики нолики": { Process.Start("креститки нолики.exe"); break; }

						}
						break;
					}
			}
		}
	}
}
