using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPAToEuropeGradingSystemSOFTWARE
{
    public partial class EURtoGPA : Form
    {
        public EURtoGPA()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EURtoGPA_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main z = (Main)Application.OpenForms["Main"];
            z.EnableButton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox3.Text);
                if (a <= 10 && a >= 4)
                {
                    double gradeEtoG = (4 * a - 16) / 6;
                    textBox4.Text = gradeEtoG.ToString();
                    if ( a>= 4 && a < 6)
                    {
                        rating.BackColor = Color.Red;
                        rating.Text = "Bad!";
                    }
                    else if (a >= 6 && a < 8)
                    {
                        rating.BackColor = Color.Orange;
                        rating.Text = "Okay!";
                    }
                    else if (a >= 8 && a < 9)
                    {
                        rating.BackColor = Color.Yellow;
                        rating.Text = "Good!";
                    }
                    else if (a >= 9 && a < 10)
                    {
                        rating.BackColor = Color.Green;
                        rating.Text = "Great!";
                    }
                    else if (a == 10)
                    {
                        rating.BackColor = Color.Lime;
                        rating.Text = "Perfect!";
                    }
                }
                else
                {
                    textBox4.Text = "NOT VALID";

                }
            }
            catch (System.FormatException a)
            {
                textBox4.Text = " ";
                rating.BackColor = Color.White;
                rating.Text = " ";
            }
        }
    }
}
