using System.Security.Cryptography;

namespace jogoDoDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int sortear()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public static int player1points = 0;
        public static int player2points = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int player1 = sortear();
            int player2 = sortear();

            label3.Text = player1.ToString();
            label4.Text = player2.ToString();

            if (player1 > player2)
            {
                player1points++;
            }
            else if (player2 > player1) 
            {
                player2points++;
            }

            if (player1points == 2) 
            {
                string retorno = ("O player 1 venceu");
                label5.Text = retorno;
            }
            else if (player2points == 2)
            {
                string retorno = ("O player 2 venceu");
                label5.Text = retorno;
            }
        }
    }
}
