namespace JSON_Foods
{
    public class Food
    {

        public string name { get; set; }

        public string category { get; set; }

        public string region { get; set; }

        public List<string> ingredients { get; set; }

        public int calories { get; set; }

        public double price_usd { get; set; }

        public bool vegetarian { get; set; }


        public Food()
        {
            name = string.Empty;
            category = string.Empty;
            region = string.Empty;
            ingredients = new List<string>();
            calories = 0;
            price_usd = 0;
            vegetarian = false;
        }

        public override string ToString()
        {
            return $"Name: {name}\nCategory: {category}\nRegion: {region}\nIngredients: {string.Join(", ", ingredients)}\nCalories: {calories}\nPrice (USD): {price_usd}\nVegetarian: {(vegetarian ? "Yes" : "No")}";
        }

    }
}