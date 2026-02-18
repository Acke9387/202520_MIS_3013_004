const int NUMBER_OF_EXAMS = 3;
//double exam1 = 0;
//double exam2 = 0;
//double exam3 = 0;

double[] exams = new double[NUMBER_OF_EXAMS];
int[] ids = new int[NUMBER_OF_EXAMS];
//Console.WriteLine("What was your exam score for exam 1? <<");
//exams[0] = double.Parse(Console.ReadLine());
//Console.WriteLine("What was your exam score for exam 2? <<");
//exams[1] = double.Parse(Console.ReadLine());
//Console.WriteLine("What was your exam score for exam 3? <<");
//exams[2] = double.Parse(Console.ReadLine());

for (int i = 0; i < exams.Length; i++)
{
    Console.WriteLine($"What was your exam score for exam {i + 1}? <<");
    exams[i] = double.Parse(Console.ReadLine());

    Console.WriteLine($"What is the id of the student with the grade of {exams[i]}? <<");
    ids[i] = int.Parse(Console.ReadLine());
}

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

average = sum / exams.Length;

Console.WriteLine($"Your average on your {exams.Length.ToString("N0")} is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyone's grade? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine($"Student:\t\tExam Grade:");
    for (int i = 0; i < exams.Length; i++)
    {
        Console.WriteLine($"{ids[i]}\t\t\t{exams[i]}");
    }
}