using System.Diagnostics.Eventing.Reader;

namespace Practica_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calificacion1 = double.Parse(textBox1.Text);
            if (calificacion1 < 3) 
            {
                MessageBox.Show("Reprobado");
            }
            else if (calificacion1 >= 3) 
            {
                MessageBox.Show("Aprobado");
           
            }




        }
    }
}
