using JSON_From_A_File;
using Newtonsoft.Json;

List<Owner> owners = new List<Owner>();
string fileContents = File.ReadAllText("Car_Owners.json");

owners  = JsonConvert.DeserializeObject<List<Owner>>(fileContents);

string answer = "No";
while (answer.ToLower() == "no")
{
    Console.WriteLine("Here are your options:\n1)Display all information from owners\n2)Display owner information who own a car with a particular color.\nWhich option do you choose either 1 or 2? <<");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1: //All info of owners
            foreach (var item in owners)
            {
                Console.WriteLine(item);
            }
            break;
        case 2: //All info based on color
            Console.WriteLine("What color do you want to see a car from? <<");
            answer = Console.ReadLine();
            foreach (var item in owners)
            {
                if (item.Color == answer)
                {
                    Console.WriteLine(item); 
                }
            }
            break;
        default:
            break;
    }

    Console.WriteLine("Do you want to exit the application? yes or no <<");
}

