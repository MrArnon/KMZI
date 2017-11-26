namespace KMZI_6
{
	partial class Testing
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
			this.Text_output = new System.Windows.Forms.TextBox();
			this.But_Start = new System.Windows.Forms.Button();
			this.But_answer = new System.Windows.Forms.Button();
			this.Text_answer = new System.Windows.Forms.TextBox();
			this.But_demon = new System.Windows.Forms.Button();
			this.Text_shifr = new System.Windows.Forms.TextBox();
			this.But_decript = new System.Windows.Forms.Button();
			this.But_theory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Text_output
			// 
			this.Text_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_output.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Text_output.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Text_output.Location = new System.Drawing.Point(63, 12);
			this.Text_output.Multiline = true;
			this.Text_output.Name = "Text_output";
			this.Text_output.ReadOnly = true;
			this.Text_output.Size = new System.Drawing.Size(449, 197);
			this.Text_output.TabIndex = 0;
			this.Text_output.TabStop = false;
			this.Text_output.Text = "Для начала тестирования нажмите кнопку \"Начать\"\r\nОтветы вводить на русском языке\r" +
    "\nДля шифрования нажмите кнопку Шифр\r\nДля расшифровки нажмите кнопку Расшифр";
			// 
			// But_Start
			// 
			this.But_Start.BackColor = System.Drawing.Color.LightSteelBlue;
			this.But_Start.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.But_Start.Location = new System.Drawing.Point(63, 258);
			this.But_Start.Name = "But_Start";
			this.But_Start.Size = new System.Drawing.Size(71, 38);
			this.But_Start.TabIndex = 1;
			this.But_Start.Text = "Начать";
			this.But_Start.UseVisualStyleBackColor = false;
			this.But_Start.Click += new System.EventHandler(this.But_Start_Click);
			// 
			// But_answer
			// 
			this.But_answer.BackColor = System.Drawing.Color.LightSteelBlue;
			this.But_answer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.But_answer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.But_answer.Location = new System.Drawing.Point(441, 258);
			this.But_answer.Name = "But_answer";
			this.But_answer.Size = new System.Drawing.Size(71, 38);
			this.But_answer.TabIndex = 2;
			this.But_answer.Text = "Ответить";
			this.But_answer.UseVisualStyleBackColor = false;
			this.But_answer.Visible = false;
			this.But_answer.Click += new System.EventHandler(this.But_answer_Click);
			// 
			// Text_answer
			// 
			this.Text_answer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_answer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Text_answer.Location = new System.Drawing.Point(63, 261);
			this.Text_answer.Name = "Text_answer";
			this.Text_answer.Size = new System.Drawing.Size(372, 30);
			this.Text_answer.TabIndex = 3;
			this.Text_answer.Visible = false;
			// 
			// But_demon
			// 
			this.But_demon.BackColor = System.Drawing.Color.LightSteelBlue;
			this.But_demon.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.But_demon.ForeColor = System.Drawing.SystemColors.ControlText;
			this.But_demon.Location = new System.Drawing.Point(268, 258);
			this.But_demon.Name = "But_demon";
			this.But_demon.Size = new System.Drawing.Size(74, 38);
			this.But_demon.TabIndex = 4;
			this.But_demon.Text = "Шифр";
			this.But_demon.UseVisualStyleBackColor = false;
			this.But_demon.Click += new System.EventHandler(this.But_demon_Click);
			// 
			// Text_shifr
			// 
			this.Text_shifr.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_shifr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Text_shifr.Location = new System.Drawing.Point(63, 302);
			this.Text_shifr.Name = "Text_shifr";
			this.Text_shifr.Size = new System.Drawing.Size(372, 30);
			this.Text_shifr.TabIndex = 5;
			// 
			// But_decript
			// 
			this.But_decript.BackColor = System.Drawing.Color.LightSteelBlue;
			this.But_decript.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.But_decript.ForeColor = System.Drawing.SystemColors.ControlText;
			this.But_decript.Location = new System.Drawing.Point(361, 258);
			this.But_decript.Name = "But_decript";
			this.But_decript.Size = new System.Drawing.Size(74, 38);
			this.But_decript.TabIndex = 6;
			this.But_decript.Text = "Расшифр";
			this.But_decript.UseVisualStyleBackColor = false;
			this.But_decript.Click += new System.EventHandler(this.But_decript_Click);
			// 
			// But_theory
			// 
			this.But_theory.BackColor = System.Drawing.Color.LightSteelBlue;
			this.But_theory.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.But_theory.ForeColor = System.Drawing.SystemColors.ControlText;
			this.But_theory.Location = new System.Drawing.Point(173, 258);
			this.But_theory.Name = "But_theory";
			this.But_theory.Size = new System.Drawing.Size(74, 38);
			this.But_theory.TabIndex = 7;
			this.But_theory.Text = "Теория";
			this.But_theory.UseVisualStyleBackColor = false;
			this.But_theory.Click += new System.EventHandler(this.But_theory_Click);
			// 
			// Testing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(577, 358);
			this.Controls.Add(this.But_theory);
			this.Controls.Add(this.But_decript);
			this.Controls.Add(this.Text_shifr);
			this.Controls.Add(this.But_demon);
			this.Controls.Add(this.Text_answer);
			this.Controls.Add(this.But_answer);
			this.Controls.Add(this.But_Start);
			this.Controls.Add(this.Text_output);
			this.MaximumSize = new System.Drawing.Size(593, 397);
			this.MinimumSize = new System.Drawing.Size(593, 397);
			this.Name = "Testing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Text_output;
		private System.Windows.Forms.Button But_Start;
		private System.Windows.Forms.Button But_answer;
		private System.Windows.Forms.TextBox Text_answer;
		private System.Windows.Forms.Button But_demon;
		private System.Windows.Forms.TextBox Text_shifr;
		private System.Windows.Forms.Button But_decript;
		private System.Windows.Forms.Button But_theory;
	}
}

