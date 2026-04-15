using System;
using System.Collections.Generic;
using System.Text;

namespace File_IO
{
    public class Student
    {
        //full_name,gender,birthdate,email,city

        public string full_name { get; set; }
        public string gender { get; set; }
        public DateTime birthdate { get; set; }
        public string email { get; set; }
        public string city { get; set; }

        public Student()
        {
            full_name = string.Empty;
            gender = string.Empty;
            birthdate = DateTime.MinValue;
            email = string.Empty;
            city = string.Empty;
        }

        public override string ToString()
        {
            return $"{full_name} was born on {birthdate.ToShortDateString()} and lives in {city}. You can contact them at {email}.";
        }

        public string ToCSV()
        {
            return $"{full_name},{gender},{birthdate},{email},{city}";
        }
    }
}
