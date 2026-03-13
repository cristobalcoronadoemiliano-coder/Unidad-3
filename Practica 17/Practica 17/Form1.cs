using System.Diagnostics.Eventing.Reader;
using System.Net.Security;

namespace Practica_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            if (a > b && b > c)
            {
                textBox4.Text = a.ToString();
                textBox5.Text = b.ToString();
                textBox6.Text = c.ToString();
            }
            else if (a > c && c > b)
            {
                textBox4.Text = a.ToString();
                textBox5.Text = c.ToString();
                textBox6.Text = b.ToString();
            }
            else if (b > a && a > c)
            {
                textBox4.Text = b.ToString();
                textBox5.Text = a.ToString();
                textBox6.Text = c.ToString();
            }
            else if (b > c && c > a)
            {
                textBox4.Text = b.ToString();
                textBox5.Text = c.ToString();
                textBox6.Text = a.ToString();
            }
            else if (c > a && a > b)
            {
                textBox4.Text = c.ToString();
                textBox5.Text = a.ToString();
                textBox6.Text = b.ToString();
            }
            else if (c > b && b > a)
            {
                textBox4.Text = c.ToString();
                textBox5.Text = b.ToString();
                textBox6.Text = a.ToString();
            }
        } 




    }

}
