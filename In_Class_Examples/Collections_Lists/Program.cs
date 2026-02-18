List<double> exams = new List<double>();
List<int> ids = new List<int>();
int i = 0;
do
{
    Console.WriteLine($"What was your exam score for exam {i+1}? <<");
    exams.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine($"What is the id of the student with the grade of {exams[i]}? <<");
    ids.Add(int.Parse(Console.ReadLine()));

    Console.WriteLine("Do you want to enter another students grade? yes or no <<");
    i++;
} while (Console.ReadLine().ToLower() == "yes");

double average = 0;
double sum = 0;
//for (int i = 0;i < exams.Length; i++)
//{
//    double grade = exams[i];
//    sum = sum + grade;
//}

foreach (double grade in exams)
{
    sum = sum + grade;
}

average = sum / exams.Count;

Console.WriteLine($"Your average on your {exams.Count.ToString("N0")} is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyone's grade? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine($"Student:\t\tExam Grade:");
    for (int x = 0; x < exams.Count; x++)
    {
        Console.WriteLine($"{ids[x]}\t\t\t{exams[x]}");
    }
}