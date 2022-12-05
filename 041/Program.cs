




// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом



int[] Array = RandomIntArray(8, -100, 100);
Print(Array);
int maxArrayNumber = FindMaxArrayNumber(Array);
int minArrayNumber = FindMinArrayNumber(Array);
System.Console.WriteLine($"Максимальное число в данном массиве равно: {maxArrayNumber}");
System.Console.WriteLine($"Минимальное число в данном массиве равно: {minArrayNumber}");
System.Console.WriteLine($"Разница между максимальным и минимальным значениями в данном массиве равна: {maxArrayNumber-minArrayNumber}");

int[] RandomIntArray(int size, int min, int max)
{
    int[] ar = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        ar[i] = random.Next(min, max+1);
    }
    return ar;
}

void Print(int[] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        System.Console.Write($"{Array[i], 5}");
    }
    System.Console.WriteLine();
}

int FindMaxArrayNumber(int[] Array)
{
    int maxNumber = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (maxNumber<Array[i])
        {
            maxNumber = Array[i];
        }
    }
    return maxNumber;
}

int FindMinArrayNumber(int[] Array)
{
    int minNumber = Array[0];
    for (int i=0; i<Array.Length; i++)
    {
        if (minNumber>Array[i])
        {
            minNumber = Array[i];
        }
    }
    return minNumber;
}