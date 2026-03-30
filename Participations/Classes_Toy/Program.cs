using Classes_Toy;

List<Toy> toys = new List<Toy>();

Toy t1 = new Toy();
t1.Manufacturer = "Hasbro";
t1.Name = "Monopoly";
t1.Price = 19.99;
//t1.Notes = "Classic board game";
t1.AddNotes("Classic board game");
t1.AddNotes("Great for family game night");

Console.WriteLine(t1);

Toy t2 = new Toy();
t2.Manufacturer = "Lego";
t2.Name = "Star Wars Millennium Falcon";
t2.Price = 159.99;
t2.AddNotes("Detailed model of the Millennium Falcon");

Console.WriteLine(t2);
toys.Add(t1);
toys.Add(t2);


// Whenever you are creating objects in a loop, make sure to create the toy object
// inside the loop so you don't keep changing the values of the same object and adding it multiple times

//while (true)
//{
//    Toy toy = new Toy();
//    toys.Add(toy);
//}