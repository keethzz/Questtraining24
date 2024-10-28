using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] game = { "Stone", "Paper", "Pencil", "Scissors" };
            int player = 0, computer = 0;
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Choose: 0.Stone  1.Paper  2.Pencil 3.Scissors");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your choice :{game[choice]}");
                int compChoice = rand.Next(0, 4);
                Console.WriteLine($"Computer : {game[compChoice]}");

                if (choice == compChoice)
                {
                    Console.WriteLine("Draw");
                }
                else if ((choice == 0 && (compChoice == 2 || compChoice == 3)) ||
                     (choice == 1 && (compChoice == 0)) ||
                     (choice == 2 && (compChoice == 1)) ||
                     (choice == 3 && (compChoice == 1)))
                {
                    player++;
                }
                else
                {
                    computer++;
                }

                Console.WriteLine($"Player: {player}, Computer: {computer}\n");

                if (player == 10)
                {
                    Console.WriteLine("You win the game.");
                    break;
                }
                else if (compChoice == 10)
                {
                    Console.WriteLine("Computer wins the gamee!");
                }
            }
        }
    }
}
