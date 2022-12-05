




// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива



int[] Array = RandomIntArray(12, -9, 9);
Print(Array);
System.Console.WriteLine($"Сумма положительных жлементов массива равна: {SumPositiveArray(Array)}");
System.Console.WriteLine($"Сумма отрицательных жлементов массива равна: {SumNegativeArray(Array)}");

int[] RandomIntArray(int size, int min, int max)
{
    int[] ar = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        ar[i] = random.Next(min, max+1); // +1, ибо в С# max всегда на 1 меньше...
    }
    return ar;
}



void Print(int[] Array)
{
    for(int i=0; i<Array.Length; i++)
    {
        System.Console.Write($"{Array[i], 5}");
    }
    System.Console.WriteLine();
}

int SumPositiveArray(int[] Array)
{
    int sum = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]>0)
        {
            sum = sum+Array[i];
        }
    }
    return sum;
}

int SumNegativeArray(int[] Array)
{
    int sum = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]<0)
        {
            sum = sum+Array[i];
        }
    }
    return sum;
}