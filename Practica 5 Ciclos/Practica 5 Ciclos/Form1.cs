namespace Practica_5_Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            while (a < 21)
            {
                listBox1.Items.Add(a);
                a++;
            }
        }
    }
}
