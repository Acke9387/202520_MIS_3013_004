/*Create a C# console application that generates a list of random numbers 
  and then uses functions to determine the smallest and largest values in that list.

When the program starts, it should generate 10 random integers 
between 1 and 100 and store them in a List<int>. 
After generating the numbers, the program should display all of 
them so the user can see the values that were created.

Next, write a function called FindMin that accepts a List<int> 
as a parameter. This function should loop through the list and 
determine the smallest number, then return that value to the main program.

You should also create another function called FindMax that also accepts 
a List<int> as a parameter. This function should loop through the 
list to determine the largest number and return it.

Finally, call both functions using the generated list 
and display the minimum and maximum values to the user.
*/


List<int> values = new List<int>();
values = GenerateRandomList(50);

PrintList(values);


int minimumValue = FindMin(values);
int maximumValue = FindMax(values);

Console.WriteLine($"\nThe maximum value is {maximumValue.ToString("N0")}");
Console.WriteLine($"The minimum value is {minimumValue.ToString("N0")}");


List<int> list2 = GenerateRandomList(5);
PrintList(list2);

Console.WriteLine($"\nThe maximum value is {FindMax(list2).ToString("N0")}");
Console.WriteLine($"The minimum value is {FindMin(list2).ToString("N0")}");


static int FindMax(List<int> values)
{
    int max = values[0];
    foreach (int val in values)
    {
        if (val > max)
        {
            max = val;
        }
    }
    return max;
}

static int FindMin(List<int> values)
{
    int min = values[0];
    //for (int i = 0; i < values.Count; i++)
    //{
    //    int val = values[i];
    //}
    foreach (int val in values)
    {
        if (val < min)
        {
            min = val;
        }
    }

    return min;
}

List<int> GenerateRandomList(int numberOfElements)
{
    List<int> randomValues = new List<int>();
    for (int i = 0; i < numberOfElements; i++)
    {
        Random r = new Random();
        randomValues.Add(r.Next(1, 101));
    }

    return randomValues;
}

void PrintList(List<int> list)
{
    foreach (int number in list)
    {
        Console.Write(number.ToString("N0") + ",");
    }
    Console.WriteLine();
}