using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Foods
{
    public class FoodsAPI
    {

        public string currency { get; set; }

        public List<Food> american_foods { get; set; }

        public FoodsAPI()
        {
            currency = string.Empty;
            american_foods = new List<Food>();
        }

    }
}
