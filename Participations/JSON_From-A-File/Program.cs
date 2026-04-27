using JSON_From_A_File;
using Newtonsoft.Json;

List<Owner> owners = new List<Owner>();
string fileContents = File.ReadAllText("Car_Owners.json");

owners  = JsonConvert.DeserializeObject<List<Owner>>(fileContents);

foreach (var item in owners)
{
    Console.WriteLine(item);
}

