
Random rnd = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = rnd.Next(min, max + 1);
    response = "";

    while (guess != number)
    {
        Console.WriteLine($"Guess a number between {min} - {max}");
        Console.Write("Enter a number: ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Guess: {guess}");

        if (guess > number)
        {
            Console.WriteLine($"{guess} is to high!");
        }
        else if (guess < number)
        {
            Console.WriteLine($"{guess} is to low!");
        }

        guesses++;
    }

    Console.Clear();
    Console.WriteLine($"***YOU WIN***");
    Console.WriteLine($"Number: {number}");
    Console.WriteLine($"Guesses: {guesses}");

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