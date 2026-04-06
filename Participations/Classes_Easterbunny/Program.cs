using Classes_Easterbunny;

List<Bunny> bunnies = new List<Bunny>();

Bunny bunny = new Bunny();
bunny.Name = "Fluffy";
bunny.Location = "South Oval";
bunny.EggCount = 100;
bunny.Age = 12;
bunny.BasketSize = 12;
bunny.DeliveryDate = "March 31, 2024";
bunny.EggColor = "Pink";
bunny.FavoriteColor = "Blue";

bunnies.Add(bunny);






foreach (Bunny b in bunnies)
{
    Console.WriteLine(b);
    Console.WriteLine($"{b.Name} will need {b.HowManyEasterBaskets()} baskets to deliver all their eggs.");
}