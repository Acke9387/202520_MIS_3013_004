const double pricePerBurrito = 9.00;
const double fixedCosts = 1200.00;
const double variableCostPerBurrito = 3.80;

int burritosSold = 0;
double revenue = -1;
double totalCost = 0.00;
double profitOrLoss = 0.00;

while (revenue <= totalCost)
{
    burritosSold++;
    //burritosSold = burritosSold + 1;
    revenue = pricePerBurrito * burritosSold;
    totalCost = fixedCosts + (variableCostPerBurrito * burritosSold);

    profitOrLoss = revenue - totalCost;

    if (profitOrLoss < 0)
    {
        Console.WriteLine($"After selling {burritosSold} burritos --> still losing money {profitOrLoss.ToString("C2")}");
    }
    else
    {
        Console.WriteLine($"After selling {burritosSold.ToString("N2")} burritos --> PROFIT! +{profitOrLoss.ToString("N2")}");
        Console.WriteLine($"Break-even point is between {(burritosSold - 1).ToString("N2")} and {burritosSold.ToString("N2")} burritos.");
        Console.WriteLine($"Minimum to make profit: {burritosSold.ToString("N2")} burritos");
    }


}






