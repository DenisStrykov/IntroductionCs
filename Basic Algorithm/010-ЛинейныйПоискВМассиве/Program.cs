




// Линейный поиск в Массиве



int[] m = RandomIntArray(10, -100, 100);

int find = 20;
m[4] = find;
int startIndex = 0;

Print(m);
System.Console.WriteLine();

int i = LineSearch(m, find, startIndex);
if (i==1)
{
    System.Console.WriteLine($"Элемент {find} не найден");
} else
{
    System.Console.WriteLine($"Элемент {find} найден на {i}");
}


int[] RandomIntArray(int size, int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        a[i] = random.Next(min, max);
    }
    return a;
}

void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}

int LineSearch(int[] m, int find, int startIndex)
{
    int i = startIndex;
    while (i<m.Length && m[i]!=find) // линейный поиск
    {
        i++;
    }
    if (i==m.Length)
    {
        return -1;  // так принято
    } else
    {
        return i;
    }
}