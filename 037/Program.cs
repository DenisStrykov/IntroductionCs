




// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел



int[] Array = RandomIntArray(5, 100, 999);
Print(Array);
int CountEvenNumbers = FindEvenNumbers(Array);
System.Console.WriteLine($"Количество четных чисел в данном массиве равно: {CountEvenNumbers}");
int CountOddNumbers = FindOddNumbers(Array);
System.Console.WriteLine($"Количество четных чисел в данном массиве равно: {CountOddNumbers}");

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

int FindEvenNumbers(int[] Array)
{
    int count = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]%2 == 0)
        count = count+1;
    }
    return count;
}

int FindOddNumbers(int[] Array)
{
    int count = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]%2 != 0)
        count = count+1;
    }
    return count;
}