using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Classes_Pharmaceutical
{
    public class Drug
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Brand { get; set; }
        public int Code { get; set; }
        public string StreetName { get; set; }

        public Drug()
        {
            Name = string.Empty;
            Company = string.Empty;
            Brand = string.Empty;
            Code = 0;
            StreetName = string.Empty;
        }

        public override string ToString()
        {
            return $"{StreetName} is made by {Company} and has a code of {Code}.";
        }
    }
}
