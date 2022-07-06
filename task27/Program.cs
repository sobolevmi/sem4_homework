// Вычисление суммы цифр введенного числа
/* Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

int sum (int num)
{
    int summa = 0;
    int count = num;
    while (count > 0)
    {
        summa = summa + count % 10;
        count = count / 10;
    }
    return summa;
}

Console.WriteLine ($"{number} {"->"} {sum (number)}"); */

/* Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

int degree (int number)
{   
    int count = number;
    int i = 0;
    for (i = 0; count > 0; i++)
    {
        count = count / 10;
    }
    return i;
}

int [] massive ()
{ 
    int [] array = new int [degree (number)];
    int count = number;
    for (int j = 1; j <= degree (number); j++)
    {
        array [degree (number) - j] = count % 10;
        count = count / 10;
    }
    return array;
}

int summa (int [] array)
{
    int sum = 0;
    for (int k = 1; k <= array.Length; k++)
    {
    sum = sum + array [array.Length - k];
    }
    return sum;
}

int [] result = massive ();
Console.WriteLine (summa (result)); */