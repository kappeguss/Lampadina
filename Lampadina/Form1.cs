namespace Lampadina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int y = 145;
        bool pos = true;

        
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(y>0)
            {
                y = y - 10;
                pictureBox2.Location = new Point(306 , y);
                pictureBox1.Location = new Point(306, y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y<285)
            {
                y = y + 10;
                pictureBox2.Location = new Point(306, y);
                pictureBox1.Location = new Point(306, y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}