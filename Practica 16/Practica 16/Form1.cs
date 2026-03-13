namespace Practica_16
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
            if (a % 2 == 0)
            {
                MessageBox.Show("El número es par.");
            }
            else
            {
                if (a % 3 == 0)
                {
                    MessageBox.Show("El número es impar y múltiplo de 3.");
                }
                else
                {
                    MessageBox.Show("El número es impar y no es múltiplo de 3.");
                }
            }
        }
    }
    using System;
    using System.Windows.Forms;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a))
            {
                MessageBox.Show("Entrada no válida.");
                return;
            }

            if (a % 2 == 0)
            {
                MessageBox.Show("El número es par.");
            }
            else if (a % 3 == 0)
            {
                MessageBox.Show("El número es impar y múltiplo de 3.");
            }
            else
            {
                MessageBox.Show("El número es impar y no es múltiplo de 3.");
            }
        }
}
 
    











