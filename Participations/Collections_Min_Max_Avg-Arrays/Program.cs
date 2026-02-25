Console.WriteLine("How many exam grades do you have? <<");
int examGradeCount = int.Parse(Console.ReadLine());

// Create an array to hold the exam grades
double[] examGrades = new double[examGradeCount];

for (int i = 0; i < examGradeCount; i++)
{
    Console.WriteLine($"Enter grade {i + 1} <<");
    double grade = double.Parse(Console.ReadLine());
    examGrades[i] = grade;
}

double minGrade = examGrades[0];
double maxGrade = examGrades[0];
double total = 0;

foreach (double grade in examGrades)
{
    if (grade < minGrade)
    {
        minGrade = grade;
    }

    if (grade > maxGrade)
    {
        maxGrade = grade;
    }

    total += grade;
}
double average = total / examGrades.Length;
Console.WriteLine($"The minimum exam grade is {minGrade:N2}");
Console.WriteLine($"The maximum exam grade is {maxGrade.ToString("N2")}");
Console.WriteLine($"The average exam grade is {average.ToString("N2")}");