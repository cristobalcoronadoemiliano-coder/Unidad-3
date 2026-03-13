namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, d, p;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);
            d = float.Parse(textBox4.Text);
            p = (a + b + c + d) / 4;

            if (a > 6 && b > 6 && c > 6 && d > 6)
                MessageBox.Show("El alumno ha aprobado con una nota de: " + p);
            else
                MessageBox.Show("El alumno ha reprobado con una nota de: " + p);





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
