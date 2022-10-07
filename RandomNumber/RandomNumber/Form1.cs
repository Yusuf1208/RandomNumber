namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayiuret = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = sayiuret.Next(1,7);
            int b = sayiuret.Next(1,7);
            label1.Text = a.ToString();
            label2.Text = b.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            label1.Text = " ";

        }
    }
}