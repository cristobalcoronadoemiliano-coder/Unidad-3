using System.Diagnostics.Eventing.Reader;

namespace Practica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sue, aum, nsue;
            sue = double.Parse(textBox1.Text);
            if (sue < 400000)
            {
                aum = sue * 0.15;
                nsue = sue + aum;
                textBox2.Text = nsue.ToString();
            }
            else
                aum = sue * 0.08;
            nsue = sue + aum;
            {
                textBox2.Text = nsue.ToString();
            }

        }
    }
}
