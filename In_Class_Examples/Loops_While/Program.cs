// Validate users input as a number

Console.WriteLine("Please enter your favorite number <<");
//int favoriteNumber = int.Parse(Console.ReadLine());
int favoriteNumber;
string input = Console.ReadLine();

while (int.TryParse(input, out favoriteNumber) == false)
{
    Console.WriteLine("That's an invalid input, please try again <<");
    input = Console.ReadLine();
}

Console.WriteLine(favoriteNumber);