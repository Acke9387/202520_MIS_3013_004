using API_ChuckNorrisJokes_Part1;
using Newtonsoft.Json;

ChuckNorrisAPI joke = new ChuckNorrisAPI();
List<ChuckNorrisAPI> jokes = new List<ChuckNorrisAPI>();
List<string> categories = new List<string>();

using (var client = new HttpClient())
{
    var response = await client.GetAsync("https://api.chucknorris.io/jokes/categories");
    if (response.IsSuccessStatusCode)
    {
        var content = await response.Content.ReadAsStringAsync();
        categories = JsonConvert.DeserializeObject<List<string>>(content);
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}

do
{
    Console.Clear();
    Console.WriteLine("Categories:");
    Console.WriteLine(" - " + "all");
    foreach (var category in categories)
    {
        Console.WriteLine(" - " + category);
    }

    Console.WriteLine("Which category do you want?");
    string selectedCategory = Console.ReadLine();

    string url = "https://api.chucknorris.io/jokes/random";
    if (selectedCategory.ToLower() != "all")
    {
        url += $"?category={selectedCategory}";
    }

    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            joke = JsonConvert.DeserializeObject<ChuckNorrisAPI>(content);
            Console.WriteLine(joke);
            jokes.Add(joke);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
    Console.WriteLine("Do you want another joke? y/n");
} while (Console.ReadLine().ToLower() == "y");

string fileName = "jokes.json";
string json = JsonConvert.SerializeObject(jokes);
File.WriteAllText(fileName, json);

Console.WriteLine("Successfully created file " + fileName);