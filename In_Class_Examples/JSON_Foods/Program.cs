using JSON_Foods;
using Newtonsoft.Json;
using System.Runtime.Intrinsics.Arm;

string fileContents = File.ReadAllText("foods.json");

FoodsAPI foodsAPI = JsonConvert.DeserializeObject<FoodsAPI>(fileContents);

Console.WriteLine("All Foods:");
//foreach (Food food in foodsAPI.american_foods)
//{
//    Console.WriteLine(food);
//    Console.WriteLine();
//}

Console.WriteLine("All foods with a bun:");
foreach (Food food in foodsAPI.american_foods)
{
    if (food.ingredients.Contains("bun"))
    {
        Console.WriteLine(food);
        Console.WriteLine(); 
    }
}