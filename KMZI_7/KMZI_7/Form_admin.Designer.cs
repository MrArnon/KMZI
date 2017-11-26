namespace KMZI_7
{
	partial class Form_admin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Box_games = new System.Windows.Forms.ComboBox();
			this.But_start = new System.Windows.Forms.Button();
			this.Text_login = new System.Windows.Forms.TextBox();
			this.Text_pass = new System.Windows.Forms.TextBox();
			this.Text_access = new System.Windows.Forms.TextBox();
			this.But_create = new System.Windows.Forms.Button();
			this.But_exit = new System.Windows.Forms.Button();
			this.But_del = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Box_games
			// 
			this.Box_games.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Box_games.FormattingEnabled = true;
			this.Box_games.Location = new System.Drawing.Point(12, 12);
			this.Box_games.Name = "Box_games";
			this.Box_games.Size = new System.Drawing.Size(153, 21);
			this.Box_games.TabIndex = 0;
			this.Box_games.TabStop = false;
			// 
			// But_start
			// 
			this.But_start.Location = new System.Drawing.Point(171, 10);
			this.But_start.Name = "But_start";
			this.But_start.Size = new System.Drawing.Size(112, 23);
			this.But_start.TabIndex = 1;
			this.But_start.Text = "Запуск";
			this.But_start.UseVisualStyleBackColor = true;
			this.But_start.Click += new System.EventHandler(this.But_start_Click);
			// 
			// Text_login
			// 
			this.Text_login.Location = new System.Drawing.Point(12, 39);
			this.Text_login.Name = "Text_login";
			this.Text_login.Size = new System.Drawing.Size(153, 20);
			this.Text_login.TabIndex = 3;
			this.Text_login.Text = "Логин";
			this.Text_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_login_KeyPress);
			// 
			// Text_pass
			// 
			this.Text_pass.Location = new System.Drawing.Point(12, 65);
			this.Text_pass.Name = "Text_pass";
			this.Text_pass.Size = new System.Drawing.Size(153, 20);
			this.Text_pass.TabIndex = 5;
			this.Text_pass.Text = "Пароль";
			this.Text_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_pass_KeyPress);
			// 
			// Text_access
			// 
			this.Text_access.Location = new System.Drawing.Point(12, 91);
			this.Text_access.Name = "Text_access";
			this.Text_access.Size = new System.Drawing.Size(153, 20);
			this.Text_access.TabIndex = 7;
			this.Text_access.Text = "Доступ";
			this.Text_access.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_access_KeyPress);
			// 
			// But_create
			// 
			this.But_create.Location = new System.Drawing.Point(171, 39);
			this.But_create.Name = "But_create";
			this.But_create.Size = new System.Drawing.Size(112, 60);
			this.But_create.TabIndex = 8;
			this.But_create.Text = "Создать\r\nили\r\nизменить";
			this.But_create.UseVisualStyleBackColor = true;
			this.But_create.Click += new System.EventHandler(this.But_create_Click);
			// 
			// But_exit
			// 
			this.But_exit.Location = new System.Drawing.Point(12, 125);
			this.But_exit.Name = "But_exit";
			this.But_exit.Size = new System.Drawing.Size(112, 23);
			this.But_exit.TabIndex = 9;
			this.But_exit.Text = "Выход";
			this.But_exit.UseVisualStyleBackColor = true;
			this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
			// 
			// But_del
			// 
			this.But_del.Location = new System.Drawing.Point(171, 105);
			this.But_del.Name = "But_del";
			this.But_del.Size = new System.Drawing.Size(112, 23);
			this.But_del.TabIndex = 10;
			this.But_del.Text = "Удалить";
			this.But_del.UseVisualStyleBackColor = true;
			this.But_del.Click += new System.EventHandler(this.But_del_Click);
			// 
			// Form_admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 160);
			this.Controls.Add(this.But_del);
			this.Controls.Add(this.But_exit);
			this.Controls.Add(this.But_create);
			this.Controls.Add(this.Text_access);
			this.Controls.Add(this.Text_pass);
			this.Controls.Add(this.Text_login);
			this.Controls.Add(this.But_start);
			this.Controls.Add(this.Box_games);
			this.MaximumSize = new System.Drawing.Size(311, 199);
			this.MinimumSize = new System.Drawing.Size(311, 199);
			this.Name = "Form_admin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Админ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox Box_games;
		private System.Windows.Forms.Button But_start;
		private System.Windows.Forms.TextBox Text_login;
		private System.Windows.Forms.TextBox Text_pass;
		private System.Windows.Forms.TextBox Text_access;
		private System.Windows.Forms.Button But_create;
		private System.Windows.Forms.Button But_exit;
		private System.Windows.Forms.Button But_del;
	}
}