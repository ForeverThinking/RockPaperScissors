using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            string computerChoice;

            string[] choices = {"Rock", "Paper", "Scissors"};

            Console.WriteLine("Welcome to Rock, Paper, Scissors.");
            Console.Write("Please make your choice: ");
            userChoice = Console.ReadLine().ToLower();

            computerChoice =  ComputerMakeChoice(choices).ToLower();

            DecideWinner(userChoice, computerChoice);
        }

        private static string ComputerMakeChoice(string[] movesToChooseFrom)
        {
            Random random = new Random();
            int randomIndex = random.Next(movesToChooseFrom.Length);
            string computerAnswer = movesToChooseFrom[randomIndex];
            return computerAnswer;
        }

        private static void DecideWinner(string playerChoice, string computerChoice)
        {
            if (playerChoice == "paper")
            {
                if (computerChoice == "rock")
                {
                    Console.WriteLine("Player wins! Paper covers rock!");
                }
                else if (computerChoice == "scissors")
                {
                    Console.WriteLine("Computer wins! Scissors cuts paper!");
                }
                else 
                {
                    Console.WriteLine("It's a draw!");
                }
            }
            else if (playerChoice == "rock")
            {
                if (computerChoice == "scissors")
                {
                    Console.WriteLine("Player wins! Rock smashes scissors!");
                }
                else if (computerChoice == "paper")
                {
                    Console.WriteLine("Computer wins! Paper covers rock!");
                }
                else 
                {
                    Console.WriteLine("It's a draw!");
                }
            }
            else if (playerChoice == "scissors")
            {
                if (computerChoice == "paper")
                {
                    Console.WriteLine("Player wins! Scissors cuts paper!");
                }
                else if (computerChoice == "rock")
                {
                    Console.WriteLine("Computer wins! Rock smashes scissors!");
                }
                else 
                {
                    Console.WriteLine("It's a draw!");
                }
            }
        }
    }
}
