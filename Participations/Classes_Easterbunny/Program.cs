using Classes_Easterbunny;

List<Bunny> bunnies = new List<Bunny>();

// Read in our file
string[] allLinesOfFile = File.ReadAllLines("Easter_Bunny.csv");

//  0   1        2          3         4        5         6           7 
//Name,Age,FavoriteColor,Location,EggCount,EggColor,BasketSize,DeliveryDate
for (int i = 1; i < allLinesOfFile.Length; i++)
{
    string line = allLinesOfFile[i];
    string[] pieces = line.Split(',');
    // pieces[0]"Name"
    // pieces[1]"Age"
    // pieces[2]"FavoriteColor"
    // pieces[3]"Location"
    // pieces[4]"EggCount"
    // pieces[5]"EggColor"
    // pieces[6]"BasketSize""
    // pieces[7]"DeliveryDate"
    Bunny b = new Bunny();
    b.Name = pieces[0];
    b.Age = int.Parse(pieces[1]);
    b.FavoriteColor = pieces[2];
    b.Location = pieces[3];
    b.EggCount = int.Parse(pieces[4]);
    b.EggColor = pieces[5];
    b.BasketSize = int.Parse(pieces[6]);
    b.DeliveryDate = pieces[7];

    bunnies.Add(b);
}


//Bunny bunny = new Bunny();
//bunny.Name = "Fluffy";
//bunny.Location = "South Oval";
//bunny.EggCount = 100;
//bunny.Age = 12;
//bunny.BasketSize = 12;
//bunny.DeliveryDate = "March 31 2024";
//bunny.EggColor = "Pink";
//bunny.FavoriteColor = "Blue";


//"Fluffy,SouthOval,100,12,March 31 2024,Pink,Blue"

//bunnies.Add(bunny);




int totalEggCount = 0;

foreach (Bunny b in bunnies)
{
    totalEggCount += b.EggCount;
}

Console.WriteLine($"Total Egg Count: {totalEggCount.ToString("N0")} \n");

Console.WriteLine("All the easter bunnies who are older than 75:");

foreach (Bunny  b in bunnies)
{
    if (b.Age > 75)
    {
        Console.WriteLine("\t" + b);
    }
}

Console.WriteLine("All the Easter Bunnies who are younger than 20:");
foreach (Bunny b in bunnies)
{
    if (b.Age < 20)
    {
        Console.WriteLine("\t" + b);
    }
}