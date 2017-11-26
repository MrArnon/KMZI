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

namespace KMZI_7
{
	public partial class Form_input : Form
	{
		
		public Form_input()
		{
			InitializeComponent();
		}

		private void Text_login_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && ch!='\b' &&ch != ',' && ch != '.' && ch!='!' && ch!='?')      // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?' 
			{
				e.Handled = true;
			}
		}

		private void Text_pass_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && ch != '\b' && ch != ',' && ch != '.' && ch != '!' && ch != '?')      // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?' 
			{
				e.Handled = true;
			}
		}

		private void But_input_Click(object sender, EventArgs e)
		{
			Liter liter = new Liter();
			File_manager file = new File_manager();
			//int Dir = new DirectoryInfo(@"\\KMZI_7\Logs").GetFiles().Length;
			string log = liter.Encript(Text_login.Text);
			file.Reader( log);
			if (log == liter.Encript(file.Admin))
			{
				if (file.Pass == liter.Encript(Text_pass.Text))
				{
					Hide();
					Form_admin f = new Form_admin();
					f.ShowDialog();
					this.Close();
				}
				else
				{
					MessageBox.Show( "Админ, вспоминай пароль", "Ошибка");
				}
			}
			else
			{
				if (file.Flag)
				{
					if (file.Pass == liter.Encript(Text_pass.Text))
					{
						Hide();
						file.Write_Data();
						Form_user f = new Form_user();
						f.Owner = this;
						f.ShowDialog();
						this.Close();

					}
					else
					{
						MessageBox.Show( "Неверно введен логин или пароль", "Ошибка");
						Text_login.Text = string.Empty;
						Text_pass.Text = string.Empty;
					}

				}
				else
				{
					MessageBox.Show( "Неверно введен логин или пароль", "Ошибка");
					Text_login.Text = string.Empty;
					Text_pass.Text = string.Empty;
				}
			}
		}
	}
}

