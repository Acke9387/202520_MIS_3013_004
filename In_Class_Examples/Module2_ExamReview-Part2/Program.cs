using Module2_ExamReview_Part2;

List<Major> majors = new List<Major>();

do
{
    Major m = new Major();
    //MajorName = string.Empty;
    //AverageSalary = 0;
    //RequiredGPA = 0;
    //GraduationRate = 0;
    //AverageStudentDebt = 0;
    //NumberOfStudents = 0;
    //RequiredCourses = 0;

    Console.WriteLine("What is the Majors name? <<");
    string major = Console.ReadLine();
    m.MajorName = major; 
    //m.MajorName = Console.ReadLine();

    Console.WriteLine("What is the average salary? <<");
    m.AverageSalary = double.Parse(Console.ReadLine());

    Console.WriteLine("What is the required GPA? <<");
    m.RequiredGPA = double.Parse(Console.ReadLine());

    Console.WriteLine("What is the graduation rate? <<");
    m.GraduationRate = double.Parse(Console.ReadLine());

    Console.WriteLine("What is the average student debt? <<");
    m.AverageStudentDebt = double.Parse(Console.ReadLine());

    Console.WriteLine("What is the number of students?<<");
    m.NumberOfStudents = int.Parse(Console.ReadLine());

    Console.WriteLine("How many required courses are there? <<");
    m.RequiredCourses = int.Parse(Console.ReadLine());

    majors.Add(m);

    Console.WriteLine("Do you have another major to add? yes or no <<");
}while (Console.ReadLine().ToLower() == "yes");


Console.WriteLine("What is the minimum average salary for a major that you want to see? <<");
double minSalary = double.Parse(Console.ReadLine());

Console.WriteLine($"Major's with an average salary of {minSalary.ToString("C")} or more:");

foreach (Major m in majors)
{
    if (m.AverageSalary >= minSalary)
    {
        Console.WriteLine(m);
    }
}