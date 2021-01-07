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


        public static string RandomComputerSelection()
        {
            Random randomNumber = new Random();
            string output = choises[randomNumber.Next(1, 3)];

            return output;
        }

        public static void PlayRound(PlayerInfoModel player, ComputerInfoModel computer, ref int playerScore, ref int computerScore, ref int round, ref string roundWinner)
        {
            if (player.PlayerSelection == computer.ComputerSelection)
            {
                return;
            }
            else if (player.PlayerSelection == "rock" && computer.ComputerSelection == "scissors" ||
                player.PlayerSelection == "paper" && computer.ComputerSelection == "rock" ||
                player.PlayerSelection == "scissors" && computer.ComputerSelection == "paper")
            {
                playerScore++;
                roundWinner = player.PlayerName;
            }
            else
            {
                computerScore++;
                roundWinner = computer.ComputerName;
            }

            round++;
            
        }

    }
}
