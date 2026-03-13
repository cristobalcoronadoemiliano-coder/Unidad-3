namespace Practica_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suel, aum, nsue;
            suel = double.Parse(textBox1.Text);
            if (suel < 400000)
            {
                aum = suel * 0.15;
                nsue = suel + aum;
                MessageBox.Show("El nuevo sueldo es: " + nsue);
            }
            else
            {
                MessageBox.Show("No se le realizara el aumento");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
