




// Написать программу замены элементов массива на противоположные



int[] Array = RandomIntArray(5, 1, 5);
Print(Array);
int[] Zamena = ZamenaArray(Array);
Print(Zamena);

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

int[] ZamenaArray(int[] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        Array[i] = Array[i]*(-1);
    }
    return Array;
}