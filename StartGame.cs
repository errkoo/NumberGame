using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class StartGame
    {
        private int mode;
        private int guesses;
        private int number;
        
        public StartGame(int mode)
        {
            this.mode = mode;
            if (mode == 1)
            {
                guesses = 7;
            }
            else if (mode == 2)
            {
                guesses = 6;
            }
            else if(mode == 3)
            {
                guesses = 5;
            }

            Random r = new Random();
            number = r.Next(100);
        }
        public int getGuesses()
        {
            return guesses;
        }
        public int getNumber()
        {
            return number;
        }
       
    }
}
