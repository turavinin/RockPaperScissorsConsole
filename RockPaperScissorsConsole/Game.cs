using RockPaperScissorsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsole
{
    public static class Game
    {
        public static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            output.PlayerName = AskPlayerName();

            return output;
        }
        public static string AskPlayerName()
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
        public static void PlayGame()
        {
            Console.Clear();

            UserMessages.IntroMessage();

            ComputerInfoModel computer = new ComputerInfoModel();
            PlayerInfoModel player = CreatePlayer();

            Console.Clear();

            UserMessages.RulesMessage(player);

            int playerScore = 0;
            int computerScore = 0;
            int round = 1;

            do
            {
                Console.WriteLine($"Round {round}");
                string roundWinner = "It's a tie!";

                player.PlayerSelection = AskPlayerSelection();
                computer.ComputerSelection = GameLogic.RandomComputerSelection();
                Console.WriteLine();

                UserMessages.PrintSelections(player, computer);
                Console.WriteLine();

                GameLogic.PlayRound(player, computer, ref playerScore, ref computerScore, ref round, ref roundWinner);

                UserMessages.PrintRoundWinner(roundWinner);
                Console.WriteLine();

                UserMessages.PrintScore(player, computer, playerScore, computerScore);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Press ANY BUTTON to start the second round.");
                Console.ReadLine();
                Console.Clear();


            } while (playerScore < 3 && computerScore < 3);

            Console.Clear();

            UserMessages.AnnounceTheWinner(playerScore, computerScore);
            Console.WriteLine();
            Console.WriteLine();

        }

        public static bool AskToRestartTheGame()
        {
            Console.Write("Do you want to play again? ( y / n ): ");
            bool output = false;
            string answer;

            bool answerIsValid = false;
            do
            {
                answer = Console.ReadLine();
                if (answer.ToLower() != "y" && answer.ToLower() != "n")
                {
                    Console.Write("Invalid answer. Please write 'y' or 'n': ");
                }
                else if (answer.ToLower() == "y")
                {
                    output = true;
                    answerIsValid = true;
                }
                else
                {
                    answerIsValid = true;
                }

            } while (answerIsValid == false);

            return output;
        }

        public static string AskPlayerSelection()
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

    }
}
