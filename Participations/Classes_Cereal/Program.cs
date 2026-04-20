
using Classes_Cereal;

string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");
List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    string[] partsOfLine = linesOfFile[i].Split('|');
    // 0         1         2      3
    //name|manufacturer|calories|cups
    Cereal temp = new Cereal();
    temp.Name = partsOfLine[0];
    temp.Manufacturer = partsOfLine[1];
    temp.Calories = int.Parse(partsOfLine[2]);
    temp.Cups = double.Parse(partsOfLine[3]);

    cereals.Add(temp);
}


//output all of the Cereal information that have a serving size that is 1 cup or more.
Console.WriteLine("Cereals with a serving size of 1 cup or more:");
foreach (var cereal in cereals)
{
    if (cereal.Cups >= 1)
    {
        Console.WriteLine($"\t{cereal}");
    }
}
Console.WriteLine();
//output all of the Cereal information that have a have 100 calories or less per serving.
Console.WriteLine("Cereals with a serving size of 100 calories or less:");
foreach (var cereal in cereals)
{
    if (cereal.Calories <= 100)
    {
        Console.WriteLine($"\t{cereal}");
    }
}