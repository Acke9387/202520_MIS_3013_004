//full_name,gender,birthdate,email,city

using File_IO;

string[] fileContents = File.ReadAllLines("students.csv");
//fileContents[0] : "full_name,gender,birthdate,email,city"

List<Student> students = new List<Student>();

for (int i = 1; i < fileContents.Length; i++)
{
    string line = fileContents[i];

    //     0       1       2        3     4
    //"full_name,gender,birthdate,email,city"

    string[] partsOfLine = line.Split(',');

    Student s = new Student();
    s.full_name = partsOfLine[0];
    s.gender = partsOfLine[1];
    s.birthdate = DateTime.Parse(partsOfLine[2]);
    s.email = partsOfLine[3];
    s.city = partsOfLine[4];

    students.Add(s);
}

// output students whose fullname starts with "B"
List<Student> studentsWithB = new List<Student>();
string newFile = "full_name,gender,birthdate,email,city";

foreach (Student s in students)
{
    if (s.full_name[0] == 'B')
    {
        studentsWithB.Add(s);
        Console.WriteLine(s);
        newFile += Environment.NewLine + s.ToCSV();
    }
}

File.WriteAllText("students_with_b.csv", newFile);
Console.WriteLine("Finished writing file to disk...");