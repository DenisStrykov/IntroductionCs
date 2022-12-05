




// Определить, присутствует ли в заданном массиве, некоторое число



int[] Array = RandomIntArray(10, 1, 5);
Print(Array);

int find = 3;
int startIndex = 0;
int foundFind = FindSearch(Array, find, startIndex);
if (foundFind==(-1))
{
    System.Console.WriteLine($"В данном массиве не присутствует значение {find}");
} else
{
    System.Console.WriteLine($"В данном массиве присутствует значение {find} на {foundFind}");
}

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

int FindSearch(int[] Array, int find, int startIndex)
{
    /*for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]==find)
        {                                   Объясните, почему не работает, не понимаю...
            return 1;
        } else                              и, как я понимаю, можно через bool решить еще, верно?
        {
            return 0;
        }
    }*/
    int i = startIndex;
    while (i<Array.Length && Array[i]!=find)
    {
        i++;
    }
    if (i==Array.Length)
    {
        return -1;
    } else
    {
        return i;
    }
}