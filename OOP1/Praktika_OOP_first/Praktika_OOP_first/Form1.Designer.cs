namespace Praktika_OOP_first
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
            this.button_sixth_task = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_seventh_task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sixth_task
            // 
            this.button_sixth_task.Location = new System.Drawing.Point(276, 78);
            this.button_sixth_task.Name = "button_sixth_task";
            this.button_sixth_task.Size = new System.Drawing.Size(99, 23);
            this.button_sixth_task.TabIndex = 1;
            this.button_sixth_task.Text = "6 задание";
            this.button_sixth_task.UseVisualStyleBackColor = true;
            this.button_sixth_task.Click += new System.EventHandler(this.button_sixth_task_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button_seventh_task
            // 
            this.button_seventh_task.Location = new System.Drawing.Point(473, 78);
            this.button_seventh_task.Name = "button_seventh_task";
            this.button_seventh_task.Size = new System.Drawing.Size(99, 23);
            this.button_seventh_task.TabIndex = 4;
            this.button_seventh_task.Text = "7 задание";
            this.button_seventh_task.UseVisualStyleBackColor = true;
            this.button_seventh_task.Click += new System.EventHandler(this.button_seventh_task_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_seventh_task);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_sixth_task);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sixth_task;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_seventh_task;
    }
}

