namespace KMZI_7
{
	partial class Form_user
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
			this.Label_login = new System.Windows.Forms.Label();
			this.But_exit = new System.Windows.Forms.Button();
			this.Label_text = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Box_games
			// 
			this.Box_games.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Box_games.FormattingEnabled = true;
			this.Box_games.Location = new System.Drawing.Point(49, 38);
			this.Box_games.Name = "Box_games";
			this.Box_games.Size = new System.Drawing.Size(153, 21);
			this.Box_games.TabIndex = 1;
			this.Box_games.TabStop = false;
			// 
			// But_start
			// 
			this.But_start.Location = new System.Drawing.Point(27, 100);
			this.But_start.Name = "But_start";
			this.But_start.Size = new System.Drawing.Size(76, 23);
			this.But_start.TabIndex = 2;
			this.But_start.Text = "Запуск";
			this.But_start.UseVisualStyleBackColor = true;
			this.But_start.Click += new System.EventHandler(this.But_start_Click);
			// 
			// Label_login
			// 
			this.Label_login.AutoSize = true;
			this.Label_login.Location = new System.Drawing.Point(154, 9);
			this.Label_login.Name = "Label_login";
			this.Label_login.Size = new System.Drawing.Size(0, 13);
			this.Label_login.TabIndex = 4;
			// 
			// But_exit
			// 
			this.But_exit.Location = new System.Drawing.Point(153, 100);
			this.But_exit.Name = "But_exit";
			this.But_exit.Size = new System.Drawing.Size(76, 23);
			this.But_exit.TabIndex = 5;
			this.But_exit.Text = "Выход";
			this.But_exit.UseVisualStyleBackColor = true;
			this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
			// 
			// Label_text
			// 
			this.Label_text.AutoSize = true;
			this.Label_text.Location = new System.Drawing.Point(24, 9);
			this.Label_text.Name = "Label_text";
			this.Label_text.Size = new System.Drawing.Size(130, 13);
			this.Label_text.TabIndex = 6;
			this.Label_text.Text = "Вы вошли под логином: ";
			// 
			// Form_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 152);
			this.Controls.Add(this.Label_text);
			this.Controls.Add(this.But_exit);
			this.Controls.Add(this.Label_login);
			this.Controls.Add(this.But_start);
			this.Controls.Add(this.Box_games);
			this.MaximumSize = new System.Drawing.Size(268, 191);
			this.MinimumSize = new System.Drawing.Size(268, 191);
			this.Name = "Form_user";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пользователь";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox Box_games;
		private System.Windows.Forms.Button But_start;
		private System.Windows.Forms.Label Label_login;
		private System.Windows.Forms.Button But_exit;
		private System.Windows.Forms.Label Label_text;
	}
}