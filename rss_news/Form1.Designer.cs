namespace rss_news
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
            this.textout_richTextBox = new System.Windows.Forms.RichTextBox();
            this.read_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.link_textBox = new System.Windows.Forms.TextBox();
            this.link_rss_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textout_richTextBox
            // 
            this.textout_richTextBox.Location = new System.Drawing.Point(5, 13);
            this.textout_richTextBox.Name = "textout_richTextBox";
            this.textout_richTextBox.Size = new System.Drawing.Size(1410, 402);
            this.textout_richTextBox.TabIndex = 0;
            this.textout_richTextBox.Text = "";
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(1215, 422);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(97, 25);
            this.read_button.TabIndex = 1;
            this.read_button.Text = "Read RSS";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1318, 421);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(97, 25);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // link_textBox
            // 
            this.link_textBox.Location = new System.Drawing.Point(73, 425);
            this.link_textBox.Name = "link_textBox";
            this.link_textBox.Size = new System.Drawing.Size(1136, 20);
            this.link_textBox.TabIndex = 3;
            this.link_textBox.Text = "https://news.un.org/feed/subscribe/ru/news/all/rss.xml";
            // 
            // link_rss_label
            // 
            this.link_rss_label.AutoSize = true;
            this.link_rss_label.Location = new System.Drawing.Point(12, 428);
            this.link_rss_label.Name = "link_rss_label";
            this.link_rss_label.Size = new System.Drawing.Size(55, 13);
            this.link_rss_label.TabIndex = 4;
            this.link_rss_label.Text = "RSS Link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 450);
            this.Controls.Add(this.link_rss_label);
            this.Controls.Add(this.link_textBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.textout_richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "RSS reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textout_richTextBox;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox link_textBox;
        private System.Windows.Forms.Label link_rss_label;
    }
}

