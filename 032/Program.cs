




// Задать массив из 8 целых элементов и вывести их на экран



int[] Array = RandomIntArray(8, -10, 10);
Print(Array);

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
}