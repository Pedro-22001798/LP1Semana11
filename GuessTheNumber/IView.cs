using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void ShowInitialMenu();
        int Guess();
        void TooLow();
        void TooHigh();
        void Congratulations(int attempts);
        void FinishGame();
    }
}