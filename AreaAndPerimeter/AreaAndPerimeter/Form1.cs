namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WidthLable_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pmtr = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox4.Text)) * 2;
            int area = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text);

            textBox3.Text = pmtr.ToString();
            textBox4.Text = area.ToString();
        }
    }
}