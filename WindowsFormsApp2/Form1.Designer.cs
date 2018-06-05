namespace WindowsFormsApp2
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.LexerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(6, 44);
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(311, 20);
            this.TextBox.TabIndex = 0;
            // 
            // LexerBox
            // 
            this.LexerBox.Location = new System.Drawing.Point(6, 121);
            this.LexerBox.Multiline = true;
            this.LexerBox.Name = "LexerBox";
            this.LexerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LexerBox.Size = new System.Drawing.Size(311, 126);
            this.LexerBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Токен";
            // 
            // click
            // 
            this.click.BackColor = System.Drawing.Color.White;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.click.ForeColor = System.Drawing.SystemColors.ControlText;
            this.click.Location = new System.Drawing.Point(120, 70);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(79, 29);
            this.click.TabIndex = 4;
            this.click.Text = "Нажми!";
            this.click.UseVisualStyleBackColor = false;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.White;
            this.Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clean.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clean.Location = new System.Drawing.Point(120, 253);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(79, 29);
            this.Clean.TabIndex = 5;
            this.Clean.Text = "Очистка";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(320, 288);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LexerBox);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Lexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox LexerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Button Clean;
    }
}


