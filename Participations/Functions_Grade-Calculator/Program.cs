List<double> grades = new List<double>();
List<double> possiblePoints = new List<double>();

int counter = 1;

do
{
    Console.WriteLine($"Please enter the grade you received for assignment {counter++} <<");
    grades.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine("Please enter the total points possible for the assignment <<");
    possiblePoints.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine("Do you have another assignment to enter? yes or no <<");

} while (Console.ReadLine().ToLower() == "yes");

double percent = CalculateOverallPercentage(grades, possiblePoints);

Console.WriteLine("Is this course Pass fail? yes or no <<");
bool passFail;
if (Console.ReadLine().ToLower() == "yes")
{
    passFail = true;
}
else
{
    passFail = false;
}

string finalGrade = DetermineFinalGrade(percent, passFail);

Console.WriteLine($"With a {percent.ToString("P")} in the class, you received a {finalGrade}");

string DetermineFinalGrade(double percent, bool shouldUseLetterGrade)
{
    string grade = "";

    if (shouldUseLetterGrade == true)
    {
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

    }
    else
    {
        if (percent >= 60)
        {
            grade = "Pass";
        }
        else
        {
            grade = "Fail";
        }
    }

    return grade;
}

//return type   functionname       ( parameters )
double CalculateOverallPercentage(List<double> pointsEarned, List<double> pointsPossible)
{
    double percent = 0.0;
    double totalPoints = 0.0;
    double totalGrade = 0.0;

    for (int i = 0; i < pointsEarned.Count; i++)
    {
        totalPoints += pointsPossible[i];
        totalGrade += pointsEarned[i];
    }
    percent = (totalGrade / totalPoints) * 100;

    return percent;
}