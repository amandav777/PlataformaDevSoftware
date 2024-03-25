namespace bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double delta = (b * b) - 4.0 * a * c;
            Console.WriteLine(delta);
            if (delta > 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                string retorno = ("As raízes são" + raiz1 + " e " + raiz2);
                label5.Text = retorno.ToString();
            }
            else if (delta == 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                string retorno = ("As raízes são iguais com o valor:" + raiz1);
                label5.Text = retorno.ToString();
            }
            else
            {
                string retorno = ("Não possui raiz");
                label5.Text = retorno.ToString();

            }

        }
    }
}
