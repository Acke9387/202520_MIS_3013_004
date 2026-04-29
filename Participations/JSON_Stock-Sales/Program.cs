using JSON_Stock_Sales;
using Newtonsoft.Json;

string fileContents = File.ReadAllText("stock_sales.json");

List<StockOption> stockOptions = JsonConvert.DeserializeObject<List<StockOption>>(fileContents);

Console.WriteLine($"1.Display information for all stock transactions.\r\n2.Display only transactions for a specific stock symbol.\r\n3.Display only transactions where the investor made a profit.");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1: //all transactions
        foreach (StockOption item in stockOptions)
        {
            Console.WriteLine(item);
        }
        break;
    case 2: //specific stock symbol
        Console.WriteLine("Enter the stock symbol:");
        string symbol = Console.ReadLine();
        foreach (StockOption item in stockOptions)
        {
            if (item.StockSymbol == symbol)
            {
                Console.WriteLine(item);
            }
        }
        break;
    case 3: //Display only transactions where the investor made a profit
        foreach (StockOption item in stockOptions)
        {
            if (item.IsProfit())
			{
				Console.WriteLine(item);
            }
        }
        break;
    default:
        break;
}