using System.Linq.Expressions;

namespace GPAToEuropeGradingSystemSOFTWARE
{
    public partial class Form1 : Form
    {
        public Form1()
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
                textBox2.Text = "NOT VALID";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox3.Text);
                if  (x <= 10 && x >= 4)
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
                textBox4.Text = "NOT VALID";
            }
        }
    }
    }
