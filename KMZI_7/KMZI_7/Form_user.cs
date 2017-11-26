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
	public partial class Form_user : Form
	{
		
		public Form_user()
		{
			InitializeComponent();
			/*	Form_input main = this.Owner as Form_input;
				if (main != null)
				{

					string s = main.Text_login.Text;
					Label_login.Text += s;
				}*/
			File_manager file = new File_manager();
			Liter liter = new Liter();
			file.Reader(file.Read_Data());
			Label_login.Text += liter.Transcript( file.Read_Data());
			Games games = new Games();
			for (int i = 0; i < games.n; i++)
			{
				Box_games.Items.Add(games.Spisok[i]);
			}
		}
		
	private void But_exit_Click(object sender, EventArgs e)
		{
			Hide();
			Form_input f = new Form_input();
			f.ShowDialog();
			this.Close();
		}

		private void But_start_Click(object sender, EventArgs e)
		{
			File_manager file = new File_manager();
			Liter liter = new Liter();
			file.Reader(liter.Encript(Label_login.Text));
			Games games = new Games();
			string str = Convert.ToString(Box_games.SelectedItem);

			games.Starting(liter.Transcript(file.Access), str);
		}
	}
}
