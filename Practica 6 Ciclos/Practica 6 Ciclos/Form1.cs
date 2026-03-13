namespace Practica_6_Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + " El número es par");
            }
            else
            {
                listBox1.Items.Add(numero + " El número es impar");
            }
            listBox1.Text = "";
            listBox1.Focus();
        }
    }
}
