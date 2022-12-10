




// Пузырьковая сортировка



int[] a = RandomIntArray(12, -50, 50);
Print(a);
int count = 0;
BubbleSort(a, out count);
Print(a);
System.Console.WriteLine(count);

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

void BubbleSort(int[] array, out int count)
{
    count = 0;
    for (int i=0; i<array.Length; i++)
    {
        for (int j=0; j<array.Length-1-i; j++) // -i  -  улучшенная версия
        {
            if (array[j]>array[j+1])
            {
                Swap(ref array[j], ref array[j+1]);
            }
            count++;
        }
    }
}