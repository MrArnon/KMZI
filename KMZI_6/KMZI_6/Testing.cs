using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
		private void But_Start_Click(object sender, EventArgs e)
		{
			Text_answer.Visible = true;
			But_answer.Visible = true;
			reader = new Reader(Convert.ToString(check_Test.Counter), Convert.ToString(check_Test.Counter));
			Text_output.Text = reader.Question;
			But_Start.Visible = false;
		}

		private void But_answer_Click(object sender, EventArgs e)
		{
			if(check_Test.Numbers_que==check_Test.Counter)
			{
				MessageBox.Show("Вы правильно ответили на " + check_Test.Right_answer + " вопросов", "Конец тестирования");
				//Text_output.Text = "Вы правильно ответили на " + check_Test.Right_answer + " вопросов" + "\r\n" + "Для продолжения нажмите кнопку продолжить";
				Text_answer.Visible = false;
				But_answer.Visible = false;
				But_Start.Visible = true;
				Text_output.Text= "Для начала тестирования нажмите кнопку Начать";
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
				Text_output.Text = reader.Question;
			}

		}
	}
}
