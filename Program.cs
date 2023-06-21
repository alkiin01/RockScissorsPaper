// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rock-paper-scissors Game !!");
            Console.Write("Enter Your Name : ");
            string PlayerName = Console.ReadLine();

            int PlayerHealth = 3;
            int CompHealth = 3;
            // char potion = 'h';
            Random random = new Random();
            while (PlayerHealth > 0 && CompHealth > 0)
            {
                Console.WriteLine("\nPlayer Health:" + PlayerHealth);
                Console.WriteLine("Computer Health:" + CompHealth);

                Console.Write("\nEnter your choice( q for Rock, w for Paper, e for Scissors, h for health potion)");

                char playerChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                char compChoice = GetComputerChoice(random);

                if (playerChoice == 'h' && PlayerHealth == 1 && random.Next(2) == 1)
                {
                    PlayerHealth++;
                    Console.WriteLine("You used a health potion and restored 1 health point!");
                }
                else
                {
                    Console.WriteLine(PlayerName + " chosed :" + GetChoiceName(playerChoice));
                    Console.WriteLine("Computer chosed :" + GetChoiceName(compChoice));
                    if (playerChoice == compChoice)
                    {
                        Console.WriteLine("Draw !! :)");
                    }
                    else if ((playerChoice == 'q' && compChoice == 'e') || (playerChoice == 'w' && compChoice == 'q') || (playerChoice == 'e' && compChoice == 'w'))
                    {
                        CompHealth--;
                        Console.WriteLine(PlayerName + "Won this Round !! :)");
                    }
                    else
                    {
                        PlayerHealth--;
                        Console.WriteLine("Computer won this Round !! :)");
                    }
                }
            }
            if (PlayerHealth == 0)
            {
                Console.WriteLine("\n Sorry, you lost the game. Better luck next time");
            }
            else
            {
                Console.WriteLine("\n  Winner winner chicken dinner !!");
            }
            Console.ReadLine();
        }
        static char GetComputerChoice(Random random)
        {
            int choice = random.Next(3);
            return choice switch
            {
                0 => 'q',
                1 => 'w',
                2 => 'e',
                _ => throw new InvalidOperationException("Invalid choice")
            };
        }
        static string GetChoiceName(char choice)
        {
            return choice switch
            {
                'q' => "Rock",
                'w' => "Paper",
                'e' => "Scissors",
                _ => throw new InvalidOperationException("Invalid choice")
            };
        }

    }
}
// Console.WriteLine("Hello, World!");
