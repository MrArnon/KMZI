namespace KMZI_7
{
	partial class Form_input
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Label_login = new System.Windows.Forms.Label();
			this.Label_pass = new System.Windows.Forms.Label();
			this.Text_pass = new System.Windows.Forms.TextBox();
			this.Text_login = new System.Windows.Forms.TextBox();
			this.But_input = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Label_login
			// 
			this.Label_login.AutoSize = true;
			this.Label_login.Location = new System.Drawing.Point(57, 9);
			this.Label_login.Name = "Label_login";
			this.Label_login.Size = new System.Drawing.Size(81, 13);
			this.Label_login.TabIndex = 0;
			this.Label_login.Text = "Введите логин";
			// 
			// Label_pass
			// 
			this.Label_pass.AutoSize = true;
			this.Label_pass.Location = new System.Drawing.Point(57, 59);
			this.Label_pass.Name = "Label_pass";
			this.Label_pass.Size = new System.Drawing.Size(88, 13);
			this.Label_pass.TabIndex = 1;
			this.Label_pass.Text = "Введите пароль";
			// 
			// Text_pass
			// 
			this.Text_pass.Location = new System.Drawing.Point(60, 75);
			this.Text_pass.Name = "Text_pass";
			this.Text_pass.Size = new System.Drawing.Size(100, 20);
			this.Text_pass.TabIndex = 2;
			this.Text_pass.UseSystemPasswordChar = true;
			this.Text_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_pass_KeyPress);
			// 
			// Text_login
			// 
			this.Text_login.Location = new System.Drawing.Point(60, 25);
			this.Text_login.Name = "Text_login";
			this.Text_login.Size = new System.Drawing.Size(100, 20);
			this.Text_login.TabIndex = 1;
			this.Text_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_login_KeyPress);
			// 
			// But_input
			// 
			this.But_input.Location = new System.Drawing.Point(60, 132);
			this.But_input.Name = "But_input";
			this.But_input.Size = new System.Drawing.Size(100, 42);
			this.But_input.TabIndex = 3;
			this.But_input.Text = "Вход";
			this.But_input.UseVisualStyleBackColor = true;
			this.But_input.Click += new System.EventHandler(this.But_input_Click);
			// 
			// Form_input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 186);
			this.Controls.Add(this.But_input);
			this.Controls.Add(this.Text_login);
			this.Controls.Add(this.Text_pass);
			this.Controls.Add(this.Label_pass);
			this.Controls.Add(this.Label_login);
			this.MaximumSize = new System.Drawing.Size(244, 225);
			this.MinimumSize = new System.Drawing.Size(244, 225);
			this.Name = "Form_input";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label_login;
		private System.Windows.Forms.Label Label_pass;
		private System.Windows.Forms.TextBox Text_pass;
		private System.Windows.Forms.Button But_input;
		private System.Windows.Forms.TextBox Text_login;
	}
}

