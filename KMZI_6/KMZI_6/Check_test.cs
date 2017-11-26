using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMZI_6
{
	class Check_test
	{
		public string Answer { get; set; }
		public bool Start { get; set; }
		public int Counter { get; set; }
		public int Right_answer { get; set; }
		public int Numbers_que { get; set; }
		public Check_test()
		{
			Answer = string.Empty;
			Start = false;
			Counter = 0; 
			Right_answer = 0;
			Numbers_que = 5;//only 5 questions
		}
		public void Control(string str)
		{
			str=str.ToLower();
			Answer=Answer.ToLower();
			if (str == Answer)
			{
				Right_answer++;
				MessageBox.Show("Верный ответ !", "Вопрос №" +Convert.ToString(Counter+1));
			}
			else
			{
				MessageBox.Show("Неверный ответ !"+ "\r\n" + "В следующий раз будте внимательние", "Вопрос №" + Convert.ToString(Counter + 1));
			}
				Counter++;
		}
	}
}
