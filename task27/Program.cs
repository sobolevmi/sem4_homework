Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

int sum (int num)
{
    int summa = 0;
    int count = num;
    for (int i = 1; count > 0; i++)
    {
        summa = summa + count % 10;
        count = count / 10;
    }
    return summa;
}

Console.WriteLine ($"{number} {"->"} {sum (number)}");