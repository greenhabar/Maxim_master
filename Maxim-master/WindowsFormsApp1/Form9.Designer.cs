namespace WindowsFormsApp1
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Применить = new System.Windows.Forms.ListBox();
            this.Сохранить = new System.Windows.Forms.ListBox();
            this.Назад = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка управления клавишей";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 381);
            this.listBox1.TabIndex = 1;
            // 
            // Применить
            // 
            this.Применить.FormattingEnabled = true;
            this.Применить.Location = new System.Drawing.Point(385, 415);
            this.Применить.Name = "Применить";
            this.Применить.Size = new System.Drawing.Size(120, 30);
            this.Применить.TabIndex = 2;
            // 
            // Сохранить
            // 
            this.Сохранить.FormattingEnabled = true;
            this.Сохранить.Location = new System.Drawing.Point(531, 415);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(120, 30);
            this.Сохранить.TabIndex = 3;
            // 
            // Назад
            // 
            this.Назад.FormattingEnabled = true;
            this.Назад.Location = new System.Drawing.Point(668, 415);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(120, 30);
            this.Назад.TabIndex = 4;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.Применить);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Настройка управления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox Применить;
        private System.Windows.Forms.ListBox Сохранить;
        private System.Windows.Forms.ListBox Назад;
    }
}