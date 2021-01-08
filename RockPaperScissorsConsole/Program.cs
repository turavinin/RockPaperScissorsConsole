using RockPaperScissorsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            do
            {
                Game.PlayGame();
                play = Game.AskToRestartTheGame();

            } while (play == true);
        }

    }
}
