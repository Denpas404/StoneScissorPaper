using StoneScissorPaperClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoneScissorPaperConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameCalculation ResaultCalculation = new GameCalculation();
            char user = '0';

            do
            {
                Console.WriteLine("Choose a number: \n\n1: Stone. \n2: Scissor. \n3: Paper. \n9: End game");
                user = Console.ReadKey(true).KeyChar;


                switch (user)
                {
                    case '1':
                        Result(ResaultCalculation.ResaultCalculation(1), game);                        
                        break;
                    case '2':
                        Result(ResaultCalculation.ResaultCalculation(2), game);
                        break;
                    case '3':
                        Result(ResaultCalculation.ResaultCalculation(3), game);
                        break;
                    case '9':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nWrong input");
                        break;
                }

            } while (user != '9');

            Console.Clear();
            Console.WriteLine("\nGame ended by user: ");
            Console.WriteLine("\n\nNumber of rounds: " + game.rounds);
            Console.WriteLine($"\nWins: {game.wins} \nLoses: {game.loses} \nDraws: {game.draws} ");

            Console.ReadKey();
        }

        public static void Result(List<string> input, Game game)
        {
            Console.Clear();
            switch (input[2])
            {
                case "win":
                    Console.WriteLine($"You have chosen: {input[0]}\nAI chose {input[1]}");
                    Console.WriteLine("\nYou won\n");
                    game.wins++;
                    game.rounds++;
                    break;
                case "lose":
                    Console.WriteLine($"You have chosen: {input[0]}\nAI chose {input[1]}");
                    Console.WriteLine("\nYou lost\n");
                    game.loses++;
                    game.rounds++;
                    break;
                default:
                    Console.WriteLine($"You have chosen: {input[0]}\nAI chose {input[1]}");
                    Console.WriteLine("\nIt's a draw\n");
                    game.draws++;
                    game.rounds++;
                    break;
            }
        }
    }
}
