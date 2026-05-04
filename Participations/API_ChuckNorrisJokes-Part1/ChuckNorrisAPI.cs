using System;
using System.Collections.Generic;
using System.Text;

namespace API_ChuckNorrisJokes_Part1
{
    public class ChuckNorrisAPI
    {

        public string value { get; set; }

        public ChuckNorrisAPI()
        {
            value = string.Empty;
        }

        public override string ToString()
        {
            return value;
        }

    }
}
