using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JSON_From_A_File
{
    public class Owner
    {

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Make { get; set; }
        public int Year { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }

        public Owner()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Make = string.Empty;
            Year = 0;
            Model = string.Empty;
            Color = string.Empty;
        }

        public override string ToString()
        {
            // display all information
            return $"{FirstName} {LastName} owns a {Make} {Model} that is {Color} made in {Year}";
        }

    }
}
