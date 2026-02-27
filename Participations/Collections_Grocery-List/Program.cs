Console.WriteLine("Welcome to the Grocery List creator.");
Console.WriteLine("You may start entering in items for your list, simply type 'done' when you are finished <<");

List<string> groceryItems = new List<string>();
string input;
do
{

    input = Console.ReadLine();
    if (input.ToLower() != "done")// && groceryItems.Contains(input) == false)
    {
        if (groceryItems.Contains(input))
        {
            Console.WriteLine("That item is already on the list, please enter a different item.");
        }
        else
        {
            groceryItems.Add(input);
        }
    }

} while (input.ToLower() != "done");

Console.WriteLine("\nFinal Grocery List");
Console.WriteLine("".PadLeft(20,'_'));
foreach (string item in groceryItems)
{
    Console.WriteLine($"-\t{item}");
}