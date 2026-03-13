using System.Numerics;
using System.Globalization;

namespace Practica_3._1_Ciclos
{
    public partial class Form1 : Form
    {  float f_num, Total=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Total.ToString(CultureInfo.CurrentCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Introduce un número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (float.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out float parsed))
            {
                listBox1.Items.Add(text);
                f_num = parsed;
                Total += f_num;
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("La entrada no es un número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }
    }
}
