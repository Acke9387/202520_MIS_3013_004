using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random random = new Random();
            int toyIndex = random.Next(0, Toys.Count);

            return Toys[toyIndex];
        }

        public override string ToString()
        {
            return $"{Owner}'s toy box is located in the {Location} and contains {Toys.Count} toys.";

            string message = $"{Owner}'s toy box is located in the {Location} and contains {Toys.Count} toys.";
            foreach (Toy toy in Toys)
            {
                message += Environment.NewLine + "\t" + toy;
            }

            return message;

        }

    }
}
