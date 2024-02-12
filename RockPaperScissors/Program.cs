
Random rnd = new Random();
bool playAgain = true;
string player;
string computer;
string response;

while (playAgain)
{
    player = "";
    computer = "";
    response = "";

    while (!player.Equals("ROCK")
        && !player.Equals("PAPER")
        && !player.Equals("SCISSORS"))
    {
        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
        player = Console.ReadLine().ToUpper();
    }

    switch (rnd.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    switch (player)
    {
        case "ROCK":
            if (computer.Equals("ROCK"))
            {
                Console.WriteLine("It's a draw!");
            }
            else if (computer.Equals("PAPER"))
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
            break;
        case "PAPER":
            if (computer.Equals("ROCK"))
            {
                Console.WriteLine("You win!");
            }
            else if (computer.Equals("PAPER"))
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            break;
        case "SCISSORS":
            if (computer.Equals("ROCK"))
            {
                Console.WriteLine("You lose!");
            }
            else if (computer.Equals("PAPER"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            break;
    }

    Console.WriteLine("Would you like play again (Y/N): ");
    response = Console.ReadLine().ToUpper();

    if (response.Equals("Y"))
    {
        playAgain = true;
        Console.Clear();
    }
    else
    {
        playAgain = false;
        Console.WriteLine("Thanks for playing =)");
    }
}

Console.ReadKey();