using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public static class GameLogic
    {
        private static readonly string[] choises = new string[]
        {
            "rock",
            "paper",
            "scissors"
        };


        public static string ComputerSelection()
        {
            Random randomNumber = new Random();
            string choise = choises[randomNumber.Next(1, 3)];

            

            return choise;
        }

        public static void PlayRound(PlayerInfoModel player, ComputerInfoModel computer, ref int playerScore, ref int computerScore)
        {
            
        }

        public static string RandomComputerSelection(ComputerInfoModel computer)
        {
            throw new NotImplementedException();
        }
    }
}
