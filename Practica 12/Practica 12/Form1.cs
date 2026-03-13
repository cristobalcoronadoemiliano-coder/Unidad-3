namespace Practica_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal= double.Parse(textBox1.Text);
            if (cal < 3) MessageBox.Show("Reprobado");
            else if (cal >= 3 && cal < 6) MessageBox.Show("Regular");
            else if (cal >= 7 && cal < 8) MessageBox.Show("Bueno");
            else if (cal >= 8 && cal <= 9) MessageBox.Show("Muy Bueno");
            else if (cal > 9 && cal <= 10) MessageBox.Show("Sobresaliente");
             else MessageBox.Show("Calificación no válida");

        }
    }
}
