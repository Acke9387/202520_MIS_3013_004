Console.WriteLine("How many bank accounts do you have? <<");
string answer = Console.ReadLine();
int numberOfAccounts;
while (int.TryParse(answer, out numberOfAccounts) == false)
{
    Console.WriteLine("Invalid input, number of bank accounts must be a whole number.\nPlease try again.<<");
    answer = Console.ReadLine();
}

double totalBalance = 0;

for (int i = 0; i < numberOfAccounts; i++)
{
    Console.WriteLine($"What is your account balance for account {(i+1).ToString("N0")}? <<");
    //double balance = double.Parse(Console.ReadLine());
    answer = Console.ReadLine();
    double balance;
    while (double.TryParse(answer, out balance) == false)
    {
        Console.WriteLine("Invalid input, account balance must be a number.\nPlease try again.<<");
        
    }
    totalBalance = totalBalance + balance;
    //totalBalance += balance;
}

Console.WriteLine($"Your total balance across all accounts is {totalBalance.ToString("C2")}");
double averageBalance = totalBalance / numberOfAccounts;
Console.WriteLine($"The average balance of all of your accounts is {averageBalance.ToString("C2")}");