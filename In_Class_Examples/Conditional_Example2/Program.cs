/*
Generate a random number with a range between 1 and 100, using the Random (Links to an external site.) class.  Once you have the random number generated, we will play the FizzBuzz Game.

If the number they provided to you is divisible by 3, then you should output the word 'Fizz'.
If the number is divisible by 5, then you should output the word 'Buzz'.
If the number is divisible by 3 AND 5, then you should output the word 'Fizzbuzz'
If the number is NOT divisible by either, just output the number back out.

e.g. 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31, 32, Fizz, 34, Buzz, Fizz, ...
 */

Random r = new Random();

int randomNumber = r.Next(1, 101); // Generates a random number between 1 and 100

Console.WriteLine("Please enter a number <<");
string input = Console.ReadLine();
randomNumber = int.Parse(input); // converts the user input to an int
randomNumber = Convert.ToInt32(input); // another way to convert the user input to an int

if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (randomNumber % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (randomNumber % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(randomNumber);
}