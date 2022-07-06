Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите степень, в которую нужно возвести число: ");
int n = Convert.ToInt32 (Console.ReadLine ());

double numbersGrade (int num, int i)
{
    double grade = Math.Pow (num, i);
    return grade;
}

double result = numbersGrade (number, n);
Console.WriteLine ($"{number} {","} {n} {"->"} {result} {"("} {number} {^n} {")"}");