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
            userChoice = Console.ReadLine();
        }
    }
}
