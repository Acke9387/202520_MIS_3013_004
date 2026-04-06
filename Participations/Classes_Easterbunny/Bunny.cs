using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Easterbunny
{
    public class Bunny
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string DeliveryDate { get; set; }
        public int BasketSize { get; set; }
        public string EggColor { get; set; }
        public int EggCount { get; set; }
        public string Location { get; set; }
        public string FavoriteColor { get; set; }

        public Bunny()
        {
            Name = string.Empty;
            Age = 0;
            DeliveryDate = string.Empty;
            BasketSize = 0;
            EggColor = string.Empty;
            EggCount = 0;
            Location = string.Empty;
            FavoriteColor = string.Empty;
        }

        // Overloaded Constructor
        public Bunny(string name, int age)
        {
            Name = name;
            Age = age;
            DeliveryDate = string.Empty;
            BasketSize = 0;
            EggColor = string.Empty;
            EggCount = 0;
            Location = string.Empty;
            FavoriteColor = string.Empty;
        }

        public int HowManyEasterBaskets()
        {
            int baskets = 0;

            baskets = (int)Math.Ceiling((double)EggCount / BasketSize);

            return baskets;
        }

        public override string ToString()
        {
           return $"Bunny Name: {Name}, Age: {Age}, Delivery Date: {DeliveryDate}, Basket Size: {BasketSize}, Egg Color: {EggColor}, Egg Count: {EggCount}, Location: {Location}, Favorite Color: {FavoriteColor}";
        }



    }
}

