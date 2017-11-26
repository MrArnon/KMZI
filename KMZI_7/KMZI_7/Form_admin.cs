using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KMZI_7
{
	public partial class Form_admin : Form
	{
		public Form_admin()
		{
			InitializeComponent();
			Games games = new Games();
			for (int i = 0; i < games.n; i++)
			{
				Box_games.Items.Add(games.Spisok[i]);
			}
		}

		private void But_start_Click(object sender, EventArgs e)
		{
			Games games = new Games();
			string str = Convert.ToString(Box_games.SelectedItem);
			games.Starting("Ю", str);
		
		}

		private void But_create_Click(object sender, EventArgs e)
		{
			File_manager file = new File_manager();
			Liter liter = new Liter();
			file.Login = liter.Encript(Text_login.Text);
			file.Pass = liter.Encript(Text_pass.Text);
			file.Access = liter.Encript(Text_access.Text);
			file.Writer(file.Login);
			if(file.Flag)
			{
				Text_login.Text = "Логин";
				Text_pass.Text = "Пароль";
				Text_access.Text = "Доступ";
				MessageBox.Show("Изменения успешно внесены");
			}
			else
			{
				Text_login.Text = "Логин";
				Text_pass.Text = "Пароль";
				Text_access.Text = "Доступ";
				MessageBox.Show("Проверте ввод","Ошибка");

			}
		}

		private void Text_login_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && ch != '\b' && ch != ',' && ch != '.' && ch != '!' && ch != '?')      // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?' 
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

		private void Text_access_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (ch!='А'&& ch != 'Б'&& ch != 'В' && ch != '\b' && ch!='Ю')      // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?' 
			{
				e.Handled = true;
			}
		}

		private void But_exit_Click(object sender, EventArgs e)
		{
			Hide();
			Form_input f = new Form_input();
			f.ShowDialog();
			this.Close();
		}

		private void But_del_Click(object sender, EventArgs e)
		{
			File_manager file = new File_manager();
			Liter liter = new Liter();
			file.Login = liter.Encript(Text_login.Text);
			if (file.Login == liter.Encript(file.Admin))
			{

				Text_login.Text = "Логин";
				Text_pass.Text = "Пароль";
				Text_access.Text = "Доступ";
				MessageBox.Show("Админа удалять нельзя!!!!");
			}
			else {
				file.Del(file.Login);
				if (file.Flag)
				{
					Text_login.Text = "Логин";
					Text_pass.Text = "Пароль";
					Text_access.Text = "Доступ";
					MessageBox.Show("Пользователь удален");
				}
				else
				{
					Text_login.Text = "Логин";
					Text_pass.Text = "Пароль";
					Text_access.Text = "Доступ";
					MessageBox.Show("Проверте ввод", "Ошибка");

				}
			}
			
		}
	}
}
