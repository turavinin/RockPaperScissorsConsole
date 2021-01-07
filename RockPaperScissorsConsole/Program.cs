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

            

            PlayerInfoModel player = AskPlayerName();

            Console.Clear();

            RulesMessage(player);


            Console.ReadLine();
        }

        private static PlayerInfoModel AskPlayerName()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.Write(" What is your name, hero: ");
            output.PlayerName = Console.ReadLine();

            return output;
        }

        private static void RulesMessage(PlayerInfoModel model)
        {
            Console.WriteLine();
            Console.WriteLine($" {model.PlayerName}, the first to win three rounds wins the game");
            Console.WriteLine();
        }

        private static void IntroMessage()
        {
            Console.WriteLine();
            Console.WriteLine(" Computers want to dominate the planet");
            Console.WriteLine(" Our only chance to survive as humans");
            Console.WriteLine(" Is to beat them in a rock-paper-scissors game.");
            Console.WriteLine(" Will you be our hero?");
            Console.WriteLine();
            Console.WriteLine(" **********************************************");
        }
    }
}
