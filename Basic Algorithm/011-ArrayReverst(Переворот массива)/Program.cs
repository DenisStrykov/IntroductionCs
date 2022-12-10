




// Переворот массива



int[] Array = RandomIntArray(9, -10, 10);
Print(Array);
Reverst(Array);
Print(Array);

int[] RandomIntArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        arr[i] = random.Next(min, max+1);
    }
    return arr;
}

void Print(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        System.Console.Write($"{array[i], 5}");
    }
    System.Console.WriteLine();
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

void Reverst(int[] array)
{
    for (int i=0; i<array.Length/2; i++)
    {
        Swap(ref array[i], ref array[array.Length-1-i]);
    }
}