using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_API
{
    public class RickAndMortyAPI
    {
        public Info info { get; set; }
        public List<Result> results { get; set; }

        public RickAndMortyAPI()
        {
            info = new Info();
            results = new List<Result>();
        }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }

        public Info()
        {
            count = 0;
            pages = 0;
            next = string.Empty;
            prev = string.Empty;
        }
    }

    public class Location
    {
        public string name { get; set; }
        public string url { get; set; }

        public Location()
        {
            name = string.Empty;
            url = string.Empty;
        }
    }

    public class Origin
    {
        public string name { get; set; }
        public string url { get; set; }

        public Origin()
        {
            name = string.Empty;
            url = string.Empty;
        }
    }

    public class Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Origin origin { get; set; }
        public Location location { get; set; }
        public string image { get; set; }
        public List<string> episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }

        public Result()
        {
            id = 0;
            name = string.Empty;
            status = string.Empty;
            species = string.Empty;
            type = string.Empty;
            gender = string.Empty;
            origin = new Origin();
            location = new Location();
            image = string.Empty;
            episode = new List<string>();
            url = string.Empty;
            created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Status: {status}, Species: {species}";
        }
    }
}