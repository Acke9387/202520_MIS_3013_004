using Classes_Pharmaceutical;

List<Drug> drugList = new List<Drug>();
string[] linesOfFile = File.ReadAllLines("Pharmaceutical Drugs.csv");

for (int i = 1; i < linesOfFile.Length; i++)
{
    Drug drug = new Drug();
    // 0     1      2     3      4
    //Name,Company,Brand,Code,StreetName
    string[] parts = linesOfFile[i].Split(",");
    drug.Name = parts[0];
    drug.Company = parts[1];
    drug.Brand = parts[2];
    drug.Code = int.Parse(parts[3]);
    drug.StreetName = parts[4];

    drugList.Add(drug);
}
Console.WriteLine("All drug names:");
DisplayAllDrugNames(drugList);

Console.WriteLine("What drug name would you like to see?");
string userInput = Console.ReadLine();
DisplayAllDrugNames(drugList, userInput);


void DisplayAllDrugNames(List<Drug> drugList, string drugName = "All")
{
    List<string> drugNames = new List<string>();
    Console.Clear();
    foreach (var d in drugList)
    {
        if (drugName == "All")
        {
            if (!drugNames.Contains(d.Name))
            {
                drugNames.Add(d.Name);
                Console.WriteLine(d.Name);
            }
        }
        else
        {
            Console.WriteLine(d);
        }
    }
}