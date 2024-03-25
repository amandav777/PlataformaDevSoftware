using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // double hoje = Convert.ToDouble(textBox1.Text);
            // double ontem = Convert.ToDouble(textBox2.Text);

            // if (hoje <= ontem * 0.95)
            // {
            //     string retorno = ("Comprar dolar");
            //     label4.Text = retorno.ToString();
            // }
            // else
            // {
            //     string retorno = ("Não vale a pena");
            //     label4.Text = retorno.ToString();
            // }

            double dolarHoje = Convert.ToDouble(textBox1.Text);
            double dolarOntem = Convert.ToDouble(textBox2.Text);
            double porcentagemParaCompra = 100 - ((dolarHoje / dolarOntem) * 100);

            if (porcentagemParaCompra >= 5)
            {
                label3.Text = "COMPRAAAAAAAA AGORA COMPRA COMPRA";
                return;
            }

            label3.Text = "Compra não amigo :(";
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
