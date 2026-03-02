Console.WriteLine("Welcome to the product tracker.");

//          KEY     VALUE
Dictionary<string, double> productCatalog = new Dictionary<string, double>();
string input = "";
do
{
    Console.WriteLine("What product would you like to keep track of? <<");
    string productName = Console.ReadLine().ToLower();

    if (productName != "done")
    {
        Console.WriteLine($"What is the price for {productName}? <<");
        double productPrice = Convert.ToDouble(Console.ReadLine());
        if (productCatalog.ContainsKey(productName) == false)
        {
            productCatalog.Add(productName, productPrice);
        }
        else
        {
            productCatalog[productName] = productPrice;
            Console.WriteLine($"{productName} was already found in catalog, but we updated the price.");
        }
    }
    else
    {
        input = productName;
    }


} while (input != "done");

do
{

    foreach (string productName in productCatalog.Keys)
    {
        Console.WriteLine($"{productName} - {productCatalog[productName].ToString("C")}");
    }

    Console.WriteLine("Would you like to edit any of the products prices? yes or no");
    input = Console.ReadLine().ToLower();
    if (input == "yes")
    {
        Console.WriteLine("what product do you want to update? <<");
        string product = Console.ReadLine();

        Console.WriteLine($"What price do you want to change {product} to? <<");
        double newPrice = Convert.ToDouble(Console.ReadLine());

        if (productCatalog.ContainsKey(product))
        {
            productCatalog[product] = newPrice;
            Console.WriteLine($"{product} price was updated to {newPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"Sorry, {product} was not found in the catalog.");
        }
    } 

} while (input != "yes");