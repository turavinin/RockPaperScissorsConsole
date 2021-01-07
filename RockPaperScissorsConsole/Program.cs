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

            PlayerInfoModel player = CreatePlayer();

            Console.Clear();

            RulesMessage(player);

            player.PlayerSelection = AskPlayerSelection();


            Console.ReadLine();
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
