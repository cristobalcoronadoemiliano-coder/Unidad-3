namespace Practica_7_Ciclo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, suma = 0;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            for (int i = a; i <= b; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text = suma.ToString();
        }
    }
}
