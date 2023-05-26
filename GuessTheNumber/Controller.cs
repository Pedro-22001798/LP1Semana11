using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private IView view;
        int targetNumber;
        int guess;
        int attempts = 0;
        bool guessedCorrectly = false;

        public Controller()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);
        }
        public void Run(IView view)
        {
            this.view = view;

            while (!guessedCorrectly)
            {
                guess = view.Guess();
                attempts++;

                if(guess == targetNumber)
                {
                    view.Congratulations(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.TooLow();
                }
                else
                {
                    view.TooHigh();
                }
            }
        }
    }
}