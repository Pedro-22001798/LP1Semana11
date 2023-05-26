using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        private Controller controller;
        public View(Controller controller)
        {
            this.controller = controller;
        }
        public void ShowInitialMenu()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");            
        }

        public int Guess()
        {
            Console.WriteLine("Take a guess:");
            int guess = Convert.ToInt32(Console.ReadLine());
            return guess;
        }

        public void TooLow()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void TooHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void Congratulations(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void FinishGame()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}