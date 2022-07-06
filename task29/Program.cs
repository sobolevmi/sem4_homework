// Объединение 8 введенных элементов в массив и его вывод на экран
int [] massive ()
{
    int [] array = new int [8];
    for (int index = 0; index < 8; index++)
    {
        Console.Write ("Введите элемент массива: ");
        array [index] = Convert.ToInt32 (Console.ReadLine ());
    }
    return array;
}

void printArray (int [] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write (arr [j]+ " ");
    }
}

int [] mas = massive ();
Console.Clear ();
printArray (mas);