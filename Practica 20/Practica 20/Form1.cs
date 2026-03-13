namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            if (a < 12)
                MessageBox.Show("Eres un niño");
            else if (a >= 12 && a < 18)
                MessageBox.Show("Eres un adolescente");
            else if (a >= 18 && a < 60)
                MessageBox.Show("Eres un adulto");
            else
                MessageBox.Show("Eres un anciano");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
