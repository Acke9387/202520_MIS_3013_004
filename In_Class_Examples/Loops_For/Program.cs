//In class example 3
Console.WriteLine("What value (maximum) would you like to perform FizzBuzz to? <<");
//string input = Console.ReadLine(); 
//int upperBound = int.Parse(input);

int upperBound = int.Parse(Console.ReadLine());

for (int i = 1; i <= upperBound; i = i + 1)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"Fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}