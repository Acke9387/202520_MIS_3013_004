//List<double> exams = new List<double>();
//List<int> ids = new List<int>();

Dictionary<int, double> studentGrades = new Dictionary<int, double>();
int i = 0;
do
{
    Console.WriteLine($"What was your exam score for exam {i + 1}? <<");
    double score = (double.Parse(Console.ReadLine()));

    Console.WriteLine($"What is the id of the student with the grade of {score}? <<");
    int id = (int.Parse(Console.ReadLine()));

    if (studentGrades.ContainsKey(id) == false)
    {
        studentGrades.Add(id, score);
    }
    else
    {
        Console.WriteLine($"Student with id {id} already has a grade of {studentGrades[id]}, do you want to update it? yes or no <<");
        if (Console.ReadLine().ToLower() == "yes")
        {
            studentGrades[id] = score;
        }
    }

    Console.WriteLine("Do you want to enter another students grade? yes or no <<");
    i++;
} while (Console.ReadLine().ToLower() == "yes");

double average = 0;
double sum = 0;
foreach (int studentID in studentGrades.Keys)
{
    sum += studentGrades[studentID];
}

//foreach (double grade in exams)
//{
//    sum = sum + grade;
//}

average = sum / studentGrades.Count;

Console.WriteLine($"Your average on your {studentGrades.Count.ToString("N0")} is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyone's grade? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine($"Student:\t\tExam Grade:");
    foreach (int studentID in studentGrades.Keys)
    {
        Console.WriteLine($"{studentID}\t\t\t{studentGrades[studentID]}");
    }
}

Console.WriteLine("What student do you want to look up, please enter their id <<");
int idToLookUp = int.Parse(Console.ReadLine());

Console.WriteLine($"Student {idToLookUp} has a grade of {studentGrades[idToLookUp]}");
