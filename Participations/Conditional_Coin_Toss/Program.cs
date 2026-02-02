//const int HEADS = 0;
//const int TAILS = 1;


Console.WriteLine("Welcome to my Coin guessing game");

Random r = new Random();
int toss = r.Next(0, 2); // Generates a number between 0 and 1

/*
 * Heads = 0
 * Tails = 1
 */
string tossAsString;
if (toss == 0) 
{
    tossAsString = "Heads";
}
else// if (toss == 1)
{  
    tossAsString = "Tails";
}
//Console.WriteLine(tossAsString); // For testing purposes only, remove or comment out in production

Console.WriteLine("Please guess either 'Heads' or 'Tails' <<");
string userGuess = Console.ReadLine(); // Users guess of either Heads or Tails

while (userGuess.ToLower() != "heads" && userGuess.ToLower() != "tails")
{
    Console.WriteLine("Invalid input. Please enter either 'Heads' or 'Tails'.");
    userGuess = Console.ReadLine();
}

Console.WriteLine($"The coin came up {tossAsString}");

if (userGuess.ToLower() == tossAsString.ToLower())
{
    Console.WriteLine("You guessed correctly!");
}
else
{
    Console.WriteLine("Sorry, better luck next time!");
}