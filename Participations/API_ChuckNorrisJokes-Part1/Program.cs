

using API_ChuckNorrisJokes_Part1;
using Newtonsoft.Json;

string url = "https://api.chucknorris.io/jokes/random";

ChuckNorrisAPI joke = new ChuckNorrisAPI();

do
{
    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            joke = JsonConvert.DeserializeObject<ChuckNorrisAPI>(content);
            Console.WriteLine(joke);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
    Console.WriteLine("Do you want another joke? y/n");
} while (Console.ReadLine().ToLower() == "y");