using System;

{
    Random random = new Random();
    int playerScore = 0;
    int opponentScore = 0;

    Console.WriteLine("Welcome to Rock, Paper, Scissors. Written in C#. Best of Three rounds, Good luck!");

    while (playerScore != 3 && opponentScore != 3)
{
    Console.WriteLine(); // Prints a blank line
    Console.WriteLine("Your score = " + playerScore + ". Opponent score = " + opponentScore);
    Console.WriteLine("Please enter 'r' for rock, 'p' for paper or 's' for scissors.");
    string playerChoice = Console.ReadLine();

    int opponentChoice = random.Next(0, 3);

    if (opponentChoice == 0) // Rock
    {
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
            default:
                Console.WriteLine("The Opponent wins this round!");
                opponentScore++;
                break;
        }
    }
    else if (opponentChoice == 1) // Paper
    {
        Console.WriteLine("Opponent chooses paper.");

        switch (playerChoice)
        {
            case "r":
                Console.WriteLine("Opponent wins this round!");
                opponentScore++;
                break;
            case "p":
                Console.WriteLine("Tie!");
                break;
            default:
                Console.WriteLine("You win this round!");
                playerScore++;
                break;
        }

    }
    else // Scissors
    {
        Console.WriteLine("Opponent chooses scissors.");

        switch (playerChoice)
        {
            case "r":
                Console.WriteLine("You win this round!");
                playerScore++;
                break;
            case "p":
                Console.WriteLine("Opponent wins this round!");
                opponentScore++;
                break;
            default:
                Console.WriteLine("Tie!");
                break;
        }
    }

}

if (playerScore == 3)
{
    Console.WriteLine("Congratulations, you have won!");
}
else
{
    Console.WriteLine("Game Over, you lose!");
}
}