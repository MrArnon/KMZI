namespace КМЗИ_4
{
    partial class Form1
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
			this.But_cript = new System.Windows.Forms.Button();
			this.But_decript = new System.Windows.Forms.Button();
			this.Numeric_value = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Numeric_value)).BeginInit();
			this.SuspendLayout();
			// 
			// But_cript
			// 
			this.But_cript.Location = new System.Drawing.Point(145, 49);
			this.But_cript.Name = "But_cript";
			this.But_cript.Size = new System.Drawing.Size(89, 23);
			this.But_cript.TabIndex = 0;
			this.But_cript.Text = "Сжать";
			this.But_cript.UseVisualStyleBackColor = true;
			this.But_cript.Click += new System.EventHandler(this.Shifr_Click);
			// 
			// But_decript
			// 
			this.But_decript.Location = new System.Drawing.Point(31, 49);
			this.But_decript.Name = "But_decript";
			this.But_decript.Size = new System.Drawing.Size(88, 23);
			this.But_decript.TabIndex = 1;
			this.But_decript.Text = "Восcтановить";
			this.But_decript.UseVisualStyleBackColor = true;
			this.But_decript.Click += new System.EventHandler(this.button1_Click);
			// 
			// Numeric_value
			// 
			this.Numeric_value.Location = new System.Drawing.Point(116, 12);
			this.Numeric_value.Name = "Numeric_value";
			this.Numeric_value.Size = new System.Drawing.Size(37, 20);
			this.Numeric_value.TabIndex = 2;
			this.Numeric_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 93);
			this.Controls.Add(this.Numeric_value);
			this.Controls.Add(this.But_decript);
			this.Controls.Add(this.But_cript);
			this.Name = "Form1";
			this.Text = "Сжатие";
			((System.ComponentModel.ISupportInitialize)(this.Numeric_value)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_cript;
        private System.Windows.Forms.Button But_decript;
		private System.Windows.Forms.NumericUpDown Numeric_value;
	}
}

