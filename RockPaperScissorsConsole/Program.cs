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
            IntroMessage();

            ComputerInfoModel computer = new ComputerInfoModel();
            PlayerInfoModel player = CreatePlayer();

            Console.Clear();

            RulesMessage(player);

            int playerScore = 0;
            int computerScore = 0;
            int round = 1;

            do
            {
                Console.WriteLine($"Round {round}");
                string roundWinner = "It's a tie!";

                player.PlayerSelection = AskPlayerSelection();
                computer.ComputerSelection= GameLogic.RandomComputerSelection();
                Console.WriteLine();
                PrintSelections(player, computer);
                Console.WriteLine();

                GameLogic.PlayRound(player, computer, ref playerScore, ref computerScore, ref round, ref roundWinner);

                PrintRoundWinner(roundWinner);
                Console.WriteLine();
                PrintScore(player, computer, playerScore, computerScore);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press ENTER to start the second round.");
                Console.ReadLine();
                Console.Clear();


            } while (playerScore < 3 || computerScore < 3);


            Console.ReadLine();
        }

        private static void PrintRoundWinner(string roundWinner)
        {
            Console.WriteLine($"The winner of the round is: {roundWinner}");
        }

        private static void PrintScore(PlayerInfoModel player, ComputerInfoModel computer, int playerScore, int computerScore)
        {
            Console.WriteLine("The score is:");
            Console.Write($"{player.PlayerName}: {playerScore} || {computer.ComputerName}: {computerScore}");
        }

        private static void PrintSelections(PlayerInfoModel player, ComputerInfoModel computer)
        {
            Console.WriteLine($"{player.PlayerName} weapon is: {player.PlayerSelection}");
            Console.WriteLine($"{computer.ComputerName} weapon is: {computer.ComputerSelection}");
        }

        private static string AskPlayerSelection()
        {
            Console.Write("Chose your weapon (Rock / Paper / Scissors): ");
            string output;

            bool isValidSelection = false;
            do
            {
                output = Console.ReadLine(); 

                if (output.ToLower() == "rock" || output.ToLower() == "paper" || output.ToLower() == "scissors")
                {
                    isValidSelection = true;
                }
                else
                {
                    Console.Write("Invalid choise. Please check the grammar and try again: ");
                }

            } while (isValidSelection == false);

            return output;
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            output.PlayerName = AskPlayerName();
            
            return output;
        }

        private static string AskPlayerName()
        {
            Console.Write("What is your name, hero: ");
            string output = Console.ReadLine();

            while (output.Length > 10)
            {
                Console.Write("Your chosen name is very long. Try a shorter one: ");
                output = Console.ReadLine();
            }

            if (output == "")
            {
                output = "Unnamed hero";
            }

            return output;
        }

        private static void RulesMessage(PlayerInfoModel model)
        {
            Console.WriteLine();
            Console.WriteLine($"{model.PlayerName}, the first to win three rounds wins the game.");
            Console.WriteLine();
        }

        private static void IntroMessage()
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
