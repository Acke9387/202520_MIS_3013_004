using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    public class Toy
    {

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public void AddNotes(string note)
        {
            Notes += note + Environment.NewLine;
        }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Notes = string.Empty;
            Price = 0.0;
        }

        public string GetAisle()
        {
            string aisle = "";
            Random r = new Random();
            aisle = Manufacturer.ToUpper()[0].ToString();
            aisle += r.Next(1, 25);

            return aisle;
        }

        public override string ToString()
        {
            return $"{Name} by {Manufacturer} costs ${Price:F2} and is found on {GetAisle()}. Notes:{Notes}";

        }
    }
}
