using System.Linq.Expressions;

namespace GPAToEuropeGradingSystemSOFTWARE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int centerX = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            int centerY = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(centerX, centerY);

        }

      





        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by iGuEs5");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GPAtoEUR x = new GPAtoEUR();
            x.StartPosition = FormStartPosition.Manual;
            float rightx = (float)(Screen.PrimaryScreen.Bounds.Width / 1.3 - x.Width / 2.0);
            float centerY = (float)(Screen.PrimaryScreen.Bounds.Height / 2.0 - x.Height / 2.0);
            x.Location = new Point((int)rightx, (int)centerY);
            x.Show();
            button1.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            EURtoGPA x = new EURtoGPA();
            x.StartPosition = FormStartPosition.Manual;
            float rightx = (float)(Screen.PrimaryScreen.Bounds.Width / 4.3 - x.Width / 2.0);
            float centerY = (float)(Screen.PrimaryScreen.Bounds.Height / 2.0 - x.Height / 2.0);
            x.Location = new Point((int)rightx, (int)centerY);
            x.Show();
            button2.Enabled = false;


        }


        //functions

        public void EnableButton1()
        {
            button1.Enabled = true;
        }
        public void EnableButton2()
        {
            button2.Enabled = true;
        }

    }
}
