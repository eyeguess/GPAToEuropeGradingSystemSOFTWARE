namespace GPAToEuropeGradingSystemSOFTWARE
{
    partial class GPAtoEUR
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
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            back1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(336, 68);
            label5.Name = "label5";
            label5.Size = new Size(58, 38);
            label5.TabIndex = 13;
            label5.Text = "RESULT \r\n\r\n";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Location = new Point(209, 63);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 63);
            label3.Name = "label3";
            label3.Size = new Size(62, 24);
            label3.TabIndex = 11;
            label3.Text = "INPUT GPA \r\nGRADE HERE\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 37);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 10;
            label1.Text = "GPA TO EUROPE GRADING";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // back1
            // 
            back1.Location = new Point(316, 109);
            back1.Name = "back1";
            back1.Size = new Size(94, 29);
            back1.TabIndex = 14;
            back1.Text = "Back";
            back1.UseVisualStyleBackColor = true;
            back1.Click += button1_Click;
            // 
            // GPAtoEUR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(422, 146);
            Controls.Add(back1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "GPAtoEUR";
            Text = "Form2";
            FormClosing += GPAtoEUR_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Button back1;
    }
}