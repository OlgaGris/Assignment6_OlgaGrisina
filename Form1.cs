using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;

namespace Assignment6_OlgaGrisina
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rock_Click(object sender, EventArgs e)
        {
            player.Text = "Rock";
            randomNumber();
            RockPaperScissors(player.Text, comp.Text);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            player.Text = "Paper";
            randomNumber();
            RockPaperScissors(player.Text, comp.Text);
        }

        private void scissor_Click(object sender, EventArgs e)
        {
            player.Text = "Scissors";
            randomNumber();
            RockPaperScissors(player.Text, comp.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void randomNumber()
        {
            Random rnd = new Random();
            int r = rnd.Next(3);
            string[] game = { "Rock", "Paper", "Scissors" };
            comp.Text = game[r];
        }
        private void RockPaperScissors(string user, string computer)
        {
            if ((user == "Rock" && computer == "Scissors")|| (user == "Scissors" && computer == "Paper")|| (user == "Paper" && computer == "Rock"))
            {
                result.Text = "You win!!!";
            }
            else if (computer == user)
            {
                result.Text = "Draw!!!";
            }
            else
            {
                result.Text = "You lose!!!";
            }
        }
    }
}