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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox3.Text);
                if (x <= 10 && x >= 4)
                {
                    double gradeEtoG = (4 * x - 16) / 6;
                    textBox4.Text = gradeEtoG.ToString();

                }
                else
                {
                    textBox4.Text = "NOT VALID";

                }
            }
            catch (System.FormatException x)
            {
                textBox4.Text = " ";
            }
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
    }
}
