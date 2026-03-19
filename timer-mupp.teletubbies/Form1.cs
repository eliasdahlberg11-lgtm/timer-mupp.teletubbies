namespace timer_mupp.teletubbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                timer2.Interval = 3000;
                pictureBox2.Visible = false;
            }
            else if (pictureBox2.Visible == false)
            {
                timer2.Interval = 500;
                pictureBox2.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            timer1.Enabled = true;

        }
    }
}
