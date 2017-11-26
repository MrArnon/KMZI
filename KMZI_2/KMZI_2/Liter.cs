using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMZI_2
{
    class Liter
    {
        private const int n = 4;
        private char lit { get; set; }
        private int[] shifr_id = new int[n];
        private int count { get; set; }
		private List<Liter> spisok { get; set; }
		private const int kol_liter = 64;//32+32 буквы русского алфавита большие и маленькие (без букв Ё ё )

		public   Liter()
        {
            lit = '0';
            for (int i = 0; i < n; i++)
            
           shifr_id[i] = 0;
            count = 0;
        }
      private  Liter( char a, int[] mas,int c=0)
        {
            lit = a;
            shifr_id = mas;
            count = c;
        }
		private Liter(string a, int[] mas, int c=0)
        {
            lit = a[0];
            shifr_id = mas;
            count = c;
        }
        private int Pop(int i)
        {
            return shifr_id[i];
        }
        private void Control()
        {
            if (count >= (n-1)) count = 0;
        }

		private Liter (int j)
        {
            // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?'    

            if (j < 1000)
            {
                if (j == 13)
                {
                    
                    int[] a = new int[n];
                    a[0] = 9999;
                    a[1] = 9898;
                    a[2] = 9779;
                    a[3] = 9000;
                    lit = (char)j;
                    shifr_id = a;
                    count = 0;
                }
                else
                {
                    if (j < 40)
                    {
                        int j_new = j * 100;
                        int[] a = new int[n];
                        a[0] = j_new;
                        a[1] = (j_new + 3) * 2;
                        a[2] = j_new * 3;
                        a[3] = (j_new + 101);
                        lit = (char)j;
                        shifr_id = a;
                        count = 0;
                    }
                    else
                    {
                        int j_new = (j + 100) * 10;
                        int[] a = new int[n];
                        a[0] = j_new;
                        a[1] = (j_new + 3) * 2;
                        a[2] = j_new * 3;
                        a[3] = (j_new + 101);
                        lit = (char)j;
                        shifr_id = a;
                        count = 0;
                    }
                }
            }
            else
            {
                int[] a = new int[n];
                a[0] = j;
                a[1] = (j + 3) * 2;
                a[2] = j * 3;
                a[3] = (j + 101);
                lit = (char)j;
                shifr_id = a;
                count = 0;
            }

            
           }

		public string Transcript(string info)
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
			return new_info;
		}
		public string Encript (string info)
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
			return  new_info;
		}
	}
}
