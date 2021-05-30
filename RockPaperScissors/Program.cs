using RockPaperScissors_Console;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string ans = "";
            int count = 0;
            int count1 = 0;

            Console.WriteLine("Welcome to RPS game");

            while (ans != "NO")
            {
                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                Console.WriteLine("Enter your choice:");
                string playerChoice=Console.ReadLine().ToUpper();
                Game game = new Game(playerChoice);
                string result = game.ReturnWinner(ref count,ref count1); 
                Console.WriteLine(result);
                Console.WriteLine("Do u want to continue(YES/NO):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + count + " times");
            Console.WriteLine("Computer wins " + count1 + " times");
        }
    }
}
