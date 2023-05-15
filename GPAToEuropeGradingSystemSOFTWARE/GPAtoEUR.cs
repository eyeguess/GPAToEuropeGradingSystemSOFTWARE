using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GPAToEuropeGradingSystemSOFTWARE
{
    public partial class GPAtoEUR : Form
    {
        public GPAtoEUR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                if (x >= 0 && x <= 4)
                {
                    double gradeGtoE = (1.5 * x) + 4;
                    textBox2.Text = gradeGtoE.ToString();

                }
                else
                {
                    textBox2.Text = "NOT VALID";

                }
            }
            catch (System.FormatException x)
            {
                textBox2.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GPAtoEUR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main z = (Main)Application.OpenForms["Main"];
            z.EnableButton1();
        }
    }
}
