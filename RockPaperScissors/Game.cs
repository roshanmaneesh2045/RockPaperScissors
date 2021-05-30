using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors_Console
{
  public class Game
    {
        private static string _playerChoice;
        public Game(string playerChoice)
        {
            _playerChoice = playerChoice;

        }
        public string ReturnWinner(ref int count, ref int count1)
        {

            
            Random rnd = new Random();
            int n = rnd.Next(0, 3);
            
            string user = _playerChoice;
            string result = "";
            Console.WriteLine("Computer:" + (GameAction)n);

            if (user == GameAction.Rock.ToString().ToUpper() && (GameAction)n == GameAction.Scissors)
            {
                result=("User wins");
                count += 1;
            }
            else if (user == GameAction.Rock.ToString().ToUpper() && (GameAction)n == GameAction.Paper)
            {
                result=("Computer wins");
                count1 += 1;
            }
            else if (user == GameAction.Paper.ToString().ToUpper() && (GameAction)n == GameAction.Rock)
            {
                result=("User wins");
                count += 1;
            }
            else if (user == GameAction.Paper.ToString().ToUpper() && (GameAction)n == GameAction.Scissors)
            {
                result=("Computer Wins");
                count1 += 1;
            }
            else if (user == GameAction.Scissors.ToString().ToUpper() && (GameAction)n == GameAction.Rock)
            {
                result=("Computer Wins");
                count1 += 1;
            }
            else if (user == GameAction.Scissors.ToString().ToUpper() && (GameAction)n == GameAction.Paper)
            {
                result=("User wins");
                count += 1;
            }
            else
            {
                result=("Same choices");
            }

            return result;
        }
    }
}
