namespace GPAToEuropeGradingSystemSOFTWARE
{
    partial class EURtoGPA
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
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            rating = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(337, 65);
            label6.Name = "label6";
            label6.Size = new Size(58, 38);
            label6.TabIndex = 14;
            label6.Text = "RESULT \r\n\r\n";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.Location = new Point(210, 62);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(121, 27);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 65);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 12;
            label4.Text = "INPUT EUROPE\r\nGRADE HERE\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(109, 37);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 11;
            label2.Text = "EUROPE TO GPA GRADING";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(84, 27);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(316, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rating
            // 
            rating.ForeColor = SystemColors.WindowText;
            rating.Location = new Point(33, 110);
            rating.Name = "rating";
            rating.ReadOnly = true;
            rating.Size = new Size(125, 27);
            rating.TabIndex = 16;
            // 
            // EURtoGPA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(422, 149);
            Controls.Add(rating);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Name = "EURtoGPA";
            Text = "EURtoGPA";
            FormClosing += EURtoGPA_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private Button button1;
        private TextBox rating;
    }
}