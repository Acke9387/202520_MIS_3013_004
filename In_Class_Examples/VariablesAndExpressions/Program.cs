// datatype variablename = value;
double favoriteNumber = 3;
string name;
name = "Adam";

double anotherNumber = 7;
double sum = favoriteNumber + anotherNumber;

string message = "Hello, " + name + "! Your favorite number is " + favoriteNumber.ToString() + ".";
message = $"Hello, {name}! Your favorite number is {favoriteNumber}.";
Console.WriteLine("Hello, World!");
Console.WriteLine(message);
