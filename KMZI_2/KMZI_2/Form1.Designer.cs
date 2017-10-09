namespace KMZI_2
{
    partial class Replace
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
            this.Insert_text_box = new System.Windows.Forms.TextBox();
            this.Insert_text_label = new System.Windows.Forms.Label();
            this.Text_shifr_label = new System.Windows.Forms.Label();
            this.Shifr_text = new System.Windows.Forms.TextBox();
            this.Еncryption_button = new System.Windows.Forms.Button();
            this.Transcript_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.File_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insert_text_box
            // 
            this.Insert_text_box.Location = new System.Drawing.Point(12, 34);
            this.Insert_text_box.Multiline = true;
            this.Insert_text_box.Name = "Insert_text_box";
            this.Insert_text_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Insert_text_box.Size = new System.Drawing.Size(478, 52);
            this.Insert_text_box.TabIndex = 0;
            // 
            // Insert_text_label
            // 
            this.Insert_text_label.AutoSize = true;
            this.Insert_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert_text_label.Location = new System.Drawing.Point(12, 9);
            this.Insert_text_label.Name = "Insert_text_label";
            this.Insert_text_label.Size = new System.Drawing.Size(259, 16);
            this.Insert_text_label.TabIndex = 1;
            this.Insert_text_label.Text = "Введите текст или считайте из файла";
            // 
            // Text_shifr_label
            // 
            this.Text_shifr_label.AutoSize = true;
            this.Text_shifr_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_shifr_label.Location = new System.Drawing.Point(9, 89);
            this.Text_shifr_label.Name = "Text_shifr_label";
            this.Text_shifr_label.Size = new System.Drawing.Size(215, 16);
            this.Text_shifr_label.TabIndex = 2;
            this.Text_shifr_label.Text = "Текст после работы программы";
            // 
            // Shifr_text
            // 
            this.Shifr_text.BackColor = System.Drawing.SystemColors.Window;
            this.Shifr_text.Location = new System.Drawing.Point(12, 108);
            this.Shifr_text.Multiline = true;
            this.Shifr_text.Name = "Shifr_text";
            this.Shifr_text.ReadOnly = true;
            this.Shifr_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Shifr_text.Size = new System.Drawing.Size(478, 57);
            this.Shifr_text.TabIndex = 3;
            // 
            // Еncryption_button
            // 
            this.Еncryption_button.Location = new System.Drawing.Point(64, 228);
            this.Еncryption_button.Name = "Еncryption_button";
            this.Еncryption_button.Size = new System.Drawing.Size(127, 51);
            this.Еncryption_button.TabIndex = 4;
            this.Еncryption_button.Text = "Зашифровать";
            this.Еncryption_button.UseVisualStyleBackColor = true;
            this.Еncryption_button.Click += new System.EventHandler(this.Еncryption_button_Click);
            // 
            // Transcript_button
            // 
            this.Transcript_button.Location = new System.Drawing.Point(297, 228);
            this.Transcript_button.Name = "Transcript_button";
            this.Transcript_button.Size = new System.Drawing.Size(127, 51);
            this.Transcript_button.TabIndex = 5;
            this.Transcript_button.Text = "Расшифровать";
            this.Transcript_button.UseVisualStyleBackColor = true;
            this.Transcript_button.Click += new System.EventHandler(this.Transcript_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(297, 171);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(127, 51);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Очистить\r\nполя";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // File_button
            // 
            this.File_button.Location = new System.Drawing.Point(64, 171);
            this.File_button.Name = "File_button";
            this.File_button.Size = new System.Drawing.Size(127, 51);
            this.File_button.TabIndex = 7;
            this.File_button.Text = "Считать данные из файла";
            this.File_button.UseVisualStyleBackColor = true;
            this.File_button.Click += new System.EventHandler(this.File_button_Click);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.File_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Transcript_button);
            this.Controls.Add(this.Еncryption_button);
            this.Controls.Add(this.Shifr_text);
            this.Controls.Add(this.Text_shifr_label);
            this.Controls.Add(this.Insert_text_label);
            this.Controls.Add(this.Insert_text_box);
            this.Name = "Replace";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Insert_text_box;
        private System.Windows.Forms.Label Insert_text_label;
        private System.Windows.Forms.Label Text_shifr_label;
        private System.Windows.Forms.TextBox Shifr_text;
        private System.Windows.Forms.Button Еncryption_button;
        private System.Windows.Forms.Button Transcript_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button File_button;
    }
}

