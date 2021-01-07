using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public static class GameLogic
    {

        

        public static void Choises()
        {
            string[] choises = new string[]
            {
                "rock",
                "paper",
                "scissors"
            };
        }

        public static int ComputerRandomSelection()
        {
            Random randomNumber = new Random();
            int output = randomNumber.Next(1, 3);

            return output;
        }
        
    }
}
