namespace The_Best_Application
{
    partial class FormMain
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
            this.Numerator1 = new System.Windows.Forms.TextBox();
            this.Numerator2 = new System.Windows.Forms.TextBox();
            this.Denominator1 = new System.Windows.Forms.TextBox();
            this.Denominator2 = new System.Windows.Forms.TextBox();
            this.Fraction1 = new System.Windows.Forms.Label();
            this.Fraction2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.Decide = new System.Windows.Forms.Button();
            this.Numerator3 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Denominator3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numerator1
            // 
            this.Numerator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numerator1.Location = new System.Drawing.Point(110, 71);
            this.Numerator1.Multiline = true;
            this.Numerator1.Name = "Numerator1";
            this.Numerator1.Size = new System.Drawing.Size(65, 65);
            this.Numerator1.TabIndex = 3;
            this.Numerator1.TextChanged += new System.EventHandler(this.Numerator1_TextChanged);
            // 
            // Numerator2
            // 
            this.Numerator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numerator2.Location = new System.Drawing.Point(299, 71);
            this.Numerator2.Multiline = true;
            this.Numerator2.Name = "Numerator2";
            this.Numerator2.Size = new System.Drawing.Size(65, 65);
            this.Numerator2.TabIndex = 4;
            // 
            // Denominator1
            // 
            this.Denominator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Denominator1.Location = new System.Drawing.Point(134, 174);
            this.Denominator1.Multiline = true;
            this.Denominator1.Name = "Denominator1";
            this.Denominator1.Size = new System.Drawing.Size(65, 65);
            this.Denominator1.TabIndex = 5;
            // 
            // Denominator2
            // 
            this.Denominator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Denominator2.Location = new System.Drawing.Point(269, 174);
            this.Denominator2.Multiline = true;
            this.Denominator2.Name = "Denominator2";
            this.Denominator2.Size = new System.Drawing.Size(65, 65);
            this.Denominator2.TabIndex = 6;
            // 
            // Fraction1
            // 
            this.Fraction1.AutoSize = true;
            this.Fraction1.BackColor = System.Drawing.Color.GhostWhite;
            this.Fraction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fraction1.Location = new System.Drawing.Point(39, 7);
            this.Fraction1.Name = "Fraction1";
            this.Fraction1.Size = new System.Drawing.Size(94, 25);
            this.Fraction1.TabIndex = 7;
            this.Fraction1.Text = "Дробь_1";
            // 
            // Fraction2
            // 
            this.Fraction2.AutoSize = true;
            this.Fraction2.BackColor = System.Drawing.Color.GhostWhite;
            this.Fraction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fraction2.Location = new System.Drawing.Point(335, 7);
            this.Fraction2.Name = "Fraction2";
            this.Fraction2.Size = new System.Drawing.Size(94, 25);
            this.Fraction2.TabIndex = 8;
            this.Fraction2.Text = "Дробь_2";
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.GhostWhite;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(364, 290);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 29);
            this.Add.TabIndex = 13;
            this.Add.TabStop = true;
            this.Add.Text = "Сложение";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.BackColor = System.Drawing.Color.GhostWhite;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(364, 342);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(136, 29);
            this.Sub.TabIndex = 14;
            this.Sub.TabStop = true;
            this.Sub.Text = "Вычитание";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.CheckedChanged += new System.EventHandler(this.Sub_CheckedChanged);
            // 
            // Decide
            // 
            this.Decide.BackColor = System.Drawing.Color.GhostWhite;
            this.Decide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decide.Location = new System.Drawing.Point(158, 307);
            this.Decide.Name = "Decide";
            this.Decide.Size = new System.Drawing.Size(160, 43);
            this.Decide.TabIndex = 15;
            this.Decide.Text = "Решить";
            this.Decide.UseVisualStyleBackColor = false;
            this.Decide.Click += new System.EventHandler(this.Decide_Click);
            // 
            // Numerator3
            // 
            this.Numerator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numerator3.Location = new System.Drawing.Point(544, 71);
            this.Numerator3.Multiline = true;
            this.Numerator3.Name = "Numerator3";
            this.Numerator3.ReadOnly = true;
            this.Numerator3.Size = new System.Drawing.Size(65, 65);
            this.Numerator3.TabIndex = 17;
            this.Numerator3.TextChanged += new System.EventHandler(this.Numerator3_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.GhostWhite;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(531, 307);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 48);
            this.Save.TabIndex = 19;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Denominator3
            // 
            this.Denominator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Denominator3.Location = new System.Drawing.Point(544, 174);
            this.Denominator3.Multiline = true;
            this.Denominator3.Name = "Denominator3";
            this.Denominator3.ReadOnly = true;
            this.Denominator3.Size = new System.Drawing.Size(65, 65);
            this.Denominator3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::The_Best_Application.Properties.Resources.ФОННННН3;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Denominator3);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Numerator3);
            this.groupBox1.Controls.Add(this.Decide);
            this.groupBox1.Controls.Add(this.Sub);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Fraction2);
            this.groupBox1.Controls.Add(this.Fraction1);
            this.groupBox1.Controls.Add(this.Denominator2);
            this.groupBox1.Controls.Add(this.Denominator1);
            this.groupBox1.Controls.Add(this.Numerator2);
            this.groupBox1.Controls.Add(this.Numerator1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 394);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(436, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "=";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Best_Application.Properties.Resources.ФОННННН;
            this.ClientSize = new System.Drawing.Size(681, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Numerator1;
        private System.Windows.Forms.TextBox Numerator2;
        private System.Windows.Forms.TextBox Denominator1;
        private System.Windows.Forms.TextBox Denominator2;
        private System.Windows.Forms.Label Fraction1;
        private System.Windows.Forms.Label Fraction2;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.Button Decide;
        private System.Windows.Forms.TextBox Numerator3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Denominator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

