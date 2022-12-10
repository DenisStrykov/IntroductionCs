




// Бинарный поиск в массиве



int[] a = RandomIntArray(8, -10, 10);
Print(a);
int find = 5;
Array.Sort(a);
int findSearch = BinSearch(a, find);
System.Console.WriteLine(findSearch);

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

int BinSearch(int[] arr, int find)
{
    int i;
    int left = 0;
    int right = arr.Length-1;
    i = left+(right-left)/2;
    while (arr[i] != find && left<right)
    {
        if (find>arr[i])
        {
            left = i;
        } else
        {
            right = i;
        }
        i = left+(right-left)/2;
    }
    if (arr[i]!=find)
        return -1;
    else
        return i;
}