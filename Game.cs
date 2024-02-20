using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Game : Form
    {
        private int currentGuess;
        private int leftGuesses;
        private int number; 
        public Game()
        {
            InitializeComponent();

            StartGame Game = new StartGame(Form1.getMode());
            leftGuesses = Game.getGuesses();
            leftGuess.Text = leftGuesses.ToString();
            number = Game.getNumber();
        }

        private void guessNumber_Click(object sender, EventArgs e)
        {
            try
            {
                currentGuess = Convert.ToInt32(userGuess.Text);
                leftGuesses--;
                leftGuess.Text = leftGuesses.ToString();
                if (CheckNumber(currentGuess) == "Good Job!")
                {
                    userHint.Text = CheckNumber(currentGuess);
                    leftGuess.Text = "-";
                    guessNumber.Visible = false;
                }
                else
                {
                    userHint.Text = CheckNumber(currentGuess);
                }
            }
            catch(Exception ex)
            {
                userHint.Text = "Submit a valid response.";
            }
        }
        private string CheckNumber(int guess)
        {
            if(guess > number)
            {
                return "Lower";
            }
            else if(guess < number)
            {
                return "Higher";
            }
            else
            {
                return "Good Job!";
            }
        }
    }
}
