do
{
    Console.WriteLine("Welcome to the number guessing game!");
    Console.WriteLine("What is the lower bound of the number you want to guess? <<");
    string lowerBoundAsString = Console.ReadLine();
    int lowerBound = int.Parse(lowerBoundAsString);

    Console.WriteLine("What is the upper bound of the number you want to guess? <<");
    int upperBound = int.Parse(Console.ReadLine());

    Random r = new Random();
    int numberToGuess = r.Next(lowerBound, upperBound + 1);

    int usersGuess = -1;
    int numberOfGuesses = 0;

    Console.WriteLine(numberToGuess);
    do
    {
        Console.WriteLine("What is your guess? <<");
        usersGuess = int.Parse(Console.ReadLine());
        numberOfGuesses++;
        //numberOfGuesses = numberOfGuesses + 1;
        if (usersGuess < numberToGuess)
        {
            Console.WriteLine("Too low, try again.");
        }
        else if (usersGuess > numberToGuess)
        {
            Console.WriteLine("Too high, try again.");
        }

    } while (usersGuess != numberToGuess);

    Console.WriteLine($"Congratulations, you guessed correctly on {numberOfGuesses.ToString("N2")} attemps!!");

    Console.WriteLine("Do you want to play again? yes or no");
} while (Console.ReadLine().ToLower()[0] == 'y');