
using JSON_API;
using Newtonsoft.Json;

var url = "https://rickandmortyapi.com/api/character";
RickAndMortyAPI api = new RickAndMortyAPI();
using (HttpClient client = new HttpClient())
{
    var response = await client.GetAsync(url);
	if (response.IsSuccessStatusCode == true)
	{
		var json = await response.Content.ReadAsStringAsync(); 
		api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
    }
}

foreach (var item in api.results)
{
    Console.WriteLine(item);
}
