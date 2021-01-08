using RockPaperScissorsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsole
{
    public class UserMessages
    {
        public static void AnnounceTheWinner(int playerScore, int computerScore)
        {
            if (playerScore == 3)
            {
                Console.WriteLine("You saved our planet hero. Here are your Bitcoins!");
            }
            else
            {
                Console.WriteLine("The aliens win.");
                Console.WriteLine();
                Console.WriteLine("Alien: \"Haha humans... always so miserable\"");
            }
        }

        public static void PrintRoundWinner(string roundWinner)
        {
            Console.WriteLine($"The winner of the round is: {roundWinner}");
        }

        public static void PrintScore(PlayerInfoModel player, ComputerInfoModel computer, int playerScore, int computerScore)
        {
            Console.WriteLine("The score is:");
            Console.Write($"{player.PlayerName}: {playerScore} || {computer.ComputerName}: {computerScore}");
        }

        public static void PrintSelections(PlayerInfoModel player, ComputerInfoModel computer)
        {
            Console.WriteLine($"{player.PlayerName} weapon is: {player.PlayerSelection}");
            Console.WriteLine($"{computer.ComputerName} weapon is: {computer.ComputerSelection}");
        }

        public static void RulesMessage(PlayerInfoModel model)
        {
            Console.WriteLine();
            Console.WriteLine($"{model.PlayerName}, the first to win three rounds wins the game.");
            Console.WriteLine();
        }

        public static void IntroMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Computers want to dominate the planet");
            Console.WriteLine("Our only chance to survive as humans");
            Console.WriteLine("Is to beat them in a rock-paper-scissors game.");
            Console.WriteLine("Will you be our hero?");
            Console.WriteLine();
            Console.WriteLine("**********************************************");
        }
    }
}
