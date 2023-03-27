using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int playerScore = 0;
        int opponentScore = 0;

        Console.WriteLine("Welcome to Rock, Paper, Scissors. Best of three rounds, good luck!");

        while (playerScore < 3 && opponentScore < 3)
        {
            Console.WriteLine(); // Prints a blank line
            Console.WriteLine($"Your score: {playerScore}. Opponent score: {opponentScore}");
            Console.WriteLine("Please enter 'r' for rock, 'p' for paper, or 's' for scissors:");
            string playerChoice = Console.ReadLine();

            int opponentChoice = random.Next(0, 3);

            switch (opponentChoice)
            {
                case 0: // Rock
                    Console.WriteLine("Opponent chooses rock.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("You win this round!");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("The opponent wins this round!");
                            opponentScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                            break;
                    }
                    break;
                case 1: // Paper
                    Console.WriteLine("Opponent chooses paper.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("The opponent wins this round!");
                            opponentScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        case "s":
                            Console.WriteLine("You win this round!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                            break;
                    }
                    break;
                case 2: // Scissors
                    Console.WriteLine("Opponent chooses scissors.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You win this round!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("The opponent wins this round!");
                            opponentScore++;
                            break;
                        case "s":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Something went wrong, try again.");
                    break;
            }
        }

        if (playerScore == 3)
        {
            Console.WriteLine("Congratulations, you have won!");
        }
        else
        {
            Console.WriteLine("Game over, you lose!");
        }

        Console.ReadLine();
    }
}
