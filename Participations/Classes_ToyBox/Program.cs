using Classes_ToyBox;

List<ToyBox> toyBoxes = new List<ToyBox>();

do
{
    Console.WriteLine("What is the owner's name? <<");
    string owner = Console.ReadLine();

    Console.WriteLine("What is the location of the toy box? <<");
    string location = Console.ReadLine();

    List<Toy> toys = GetAllToysForToyBox();

    ToyBox tb = new ToyBox();
    tb.Toys = toys;
    tb.Location = location;
    tb.Owner = owner;

    toyBoxes.Add(tb);
    Console.WriteLine("Do you have another toybox to add? yes or no <<");
} while (Console.ReadLine().ToLower() == "yes");


foreach (ToyBox box in toyBoxes)
{
    Console.WriteLine(box);
    foreach (Toy toy in box.Toys)
    {
        Console.WriteLine("\t" + toy);
    }
    Console.WriteLine();
}

foreach (ToyBox box in toyBoxes)
{
    Console.WriteLine($"Random toy from {box.Owner}'s Toybox:");
    Console.WriteLine(box.GetRandomToy());
    Console.WriteLine();
}

List<Toy> GetAllToysForToyBox()
{
    List<Toy> userInputs = new List<Toy>();

    do
    {
        Console.WriteLine("What is the manufacturer of the Toy? <<");
        string manufacturer = Console.ReadLine();

        Console.WriteLine("What is the name of the Toy? <<");
        string name = Console.ReadLine();

        Console.WriteLine("What is the price of the toy? <<");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("What are the notes for this toy? <<");
        string notes = Console.ReadLine();

        Toy temp = new Toy(manufacturer, name, price, notes);
        //Toy temp = new Toy();
        //temp.Manufacturer = manufacturer;
        //temp.Name = name;
        //temp.Price = price;
        //temp.AddNotes(notes); 

        userInputs.Add(temp);
        Console.WriteLine("Do you have another toy to add? yes or no <<");
    } while (Console.ReadLine().ToLower() == "yes");


    return userInputs;
}