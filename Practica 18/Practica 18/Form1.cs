namespace Practica_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            if (a == b && b == c)
            {
                textBox4.Text = "El triangulo es equilatero";
            }
            else if (a == b || a == c || b == c)
            {
                textBox4.Text = "El triangulo es isosceles";
            }
            else
            {
                textBox4.Text = "El triangulo es escaleno";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
