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
			this.SuspendLayout();
			// 
			// Text_output
			// 
			this.Text_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_output.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Text_output.Location = new System.Drawing.Point(63, 12);
			this.Text_output.Multiline = true;
			this.Text_output.Name = "Text_output";
			this.Text_output.ReadOnly = true;
			this.Text_output.Size = new System.Drawing.Size(449, 197);
			this.Text_output.TabIndex = 0;
			this.Text_output.TabStop = false;
			this.Text_output.Text = "Для начала тестирования нажмите кнопку \"Начать\"\r\nОтветы вводить на русском языке";
			// 
			// But_Start
			// 
			this.But_Start.Location = new System.Drawing.Point(63, 258);
			this.But_Start.Name = "But_Start";
			this.But_Start.Size = new System.Drawing.Size(71, 38);
			this.But_Start.TabIndex = 1;
			this.But_Start.Text = "Начать";
			this.But_Start.UseVisualStyleBackColor = true;
			this.But_Start.Click += new System.EventHandler(this.But_Start_Click);
			// 
			// But_answer
			// 
			this.But_answer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.But_answer.Location = new System.Drawing.Point(441, 258);
			this.But_answer.Name = "But_answer";
			this.But_answer.Size = new System.Drawing.Size(71, 38);
			this.But_answer.TabIndex = 2;
			this.But_answer.Text = "Ответить";
			this.But_answer.UseVisualStyleBackColor = true;
			this.But_answer.Visible = false;
			this.But_answer.Click += new System.EventHandler(this.But_answer_Click);
			// 
			// Text_answer
			// 
			this.Text_answer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_answer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Text_answer.Location = new System.Drawing.Point(63, 268);
			this.Text_answer.Name = "Text_answer";
			this.Text_answer.Size = new System.Drawing.Size(372, 26);
			this.Text_answer.TabIndex = 3;
			this.Text_answer.Visible = false;
			// 
			// Testing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 337);
			this.Controls.Add(this.Text_answer);
			this.Controls.Add(this.But_answer);
			this.Controls.Add(this.But_Start);
			this.Controls.Add(this.Text_output);
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
	}
}

