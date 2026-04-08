do
{
    Console.WriteLine("Please enter the value, in feet <<");
    double ft = Convert.ToDouble(Console.ReadLine());

    double m = FeetToMeters(ft);

    Console.WriteLine($"{ft.ToString("N")} converted to meters is {m.ToString("N")}");
    Console.WriteLine("Do you have another value to convert? yes or no <<");
} while (Console.ReadLine().ToLower() == "yes");



// returnType FunctionName (parameters)
double FeetToMeters(double feet)
{
    double meters = 0;

    meters = feet * 0.3048;

    return meters;
}
