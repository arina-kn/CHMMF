namespace course_work_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_alpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_size_K = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_size_I = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_hr = new System.Windows.Forms.Label();
            this.label_ht = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.listBox_x = new System.Windows.Forms.ListBox();
            this.textBox_new_x = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_new_t = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox_t = new System.Windows.Forms.ListBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_u0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "с = ";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(60, 10);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(283, 20);
            this.textBox_c.TabIndex = 1;
            this.textBox_c.Text = "1,32";
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(60, 36);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(283, 20);
            this.textBox_k.TabIndex = 3;
            this.textBox_k.Text = "0,08";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "k = ";
            // 
            // textBox_alpha
            // 
            this.textBox_alpha.Location = new System.Drawing.Point(60, 62);
            this.textBox_alpha.Name = "textBox_alpha";
            this.textBox_alpha.Size = new System.Drawing.Size(283, 20);
            this.textBox_alpha.TabIndex = 5;
            this.textBox_alpha.Text = "0,005";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "alpha = ";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(60, 115);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(283, 20);
            this.textBox_T.TabIndex = 11;
            this.textBox_T.Text = "100";
            this.textBox_T.TextChanged += new System.EventHandler(this.textBox_T_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "T = ";
            // 
            // textBox_size_K
            // 
            this.textBox_size_K.Location = new System.Drawing.Point(60, 193);
            this.textBox_size_K.Name = "textBox_size_K";
            this.textBox_size_K.Size = new System.Drawing.Size(283, 20);
            this.textBox_size_K.TabIndex = 15;
            this.textBox_size_K.Text = "5000";
            this.textBox_size_K.TextChanged += new System.EventHandler(this.textBox_size_K_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "K = ";
            // 
            // textBox_size_I
            // 
            this.textBox_size_I.Location = new System.Drawing.Point(60, 167);
            this.textBox_size_I.Name = "textBox_size_I";
            this.textBox_size_I.Size = new System.Drawing.Size(283, 20);
            this.textBox_size_I.TabIndex = 13;
            this.textBox_size_I.Text = "100";
            this.textBox_size_I.TextChanged += new System.EventHandler(this.textBox_size_I_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "I = ";
            // 
            // label_hr
            // 
            this.label_hr.AutoSize = true;
            this.label_hr.Location = new System.Drawing.Point(28, 225);
            this.label_hr.Name = "label_hr";
            this.label_hr.Size = new System.Drawing.Size(72, 13);
            this.label_hr.TabIndex = 16;
            this.label_hr.Text = "hx = 3252346";
            // 
            // label_ht
            // 
            this.label_ht.AutoSize = true;
            this.label_ht.Location = new System.Drawing.Point(191, 225);
            this.label_ht.Name = "label_ht";
            this.label_ht.Size = new System.Drawing.Size(70, 13);
            this.label_ht.TabIndex = 17;
            this.label_ht.Text = "ht = 3252346";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Control;
            this.button_start.Location = new System.Drawing.Point(60, 457);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(283, 31);
            this.button_start.TabIndex = 21;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // listBox_x
            // 
            this.listBox_x.FormattingEnabled = true;
            this.listBox_x.Location = new System.Drawing.Point(60, 286);
            this.listBox_x.Name = "listBox_x";
            this.listBox_x.Size = new System.Drawing.Size(118, 160);
            this.listBox_x.TabIndex = 22;
            this.listBox_x.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_x_KeyDown);
            // 
            // textBox_new_x
            // 
            this.textBox_new_x.Location = new System.Drawing.Point(60, 260);
            this.textBox_new_x.Name = "textBox_new_x";
            this.textBox_new_x.Size = new System.Drawing.Size(118, 20);
            this.textBox_new_x.TabIndex = 24;
            this.textBox_new_x.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_new_x_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "x = ";
            // 
            // textBox_new_t
            // 
            this.textBox_new_t.Location = new System.Drawing.Point(225, 263);
            this.textBox_new_t.Name = "textBox_new_t";
            this.textBox_new_t.Size = new System.Drawing.Size(118, 20);
            this.textBox_new_t.TabIndex = 26;
            this.textBox_new_t.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_new_t_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "t = ";
            // 
            // listBox_t
            // 
            this.listBox_t.FormattingEnabled = true;
            this.listBox_t.Location = new System.Drawing.Point(225, 289);
            this.listBox_t.Name = "listBox_t";
            this.listBox_t.Size = new System.Drawing.Size(118, 160);
            this.listBox_t.TabIndex = 27;
            this.listBox_t.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_t_KeyDown);
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(60, 141);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(283, 20);
            this.textBox_L.TabIndex = 31;
            this.textBox_L.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "L = ";
            // 
            // textBox_u0
            // 
            this.textBox_u0.Location = new System.Drawing.Point(60, 89);
            this.textBox_u0.Name = "textBox_u0";
            this.textBox_u0.Size = new System.Drawing.Size(283, 20);
            this.textBox_u0.TabIndex = 33;
            this.textBox_u0.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "u0 = ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 505);
            this.Controls.Add(this.textBox_u0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_L);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_t);
            this.Controls.Add(this.textBox_new_t);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_new_x);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox_x);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_ht);
            this.Controls.Add(this.label_hr);
            this.Controls.Add(this.textBox_size_K);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_size_I);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_alpha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_k);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_alpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_size_K;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_size_I;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_hr;
        private System.Windows.Forms.Label label_ht;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ListBox listBox_x;
        private System.Windows.Forms.TextBox textBox_new_x;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_new_t;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox_t;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_u0;
        private System.Windows.Forms.Label label4;
    }
}

