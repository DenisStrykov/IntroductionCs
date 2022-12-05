




// Найти сумму чисел одномерного массива стоящих на нечетной позиции



int[] Array = RandomIntArray(7, 0, 1);
Print(Array);
int findSumOddNubbers = SearchSumOddNumbers(Array);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в данном массиве равна: {findSumOddNubbers}");

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

int SearchSumOddNumbers(int[] Array)
{
    int sum = 0;
    for (int i=1; i<Array.Length; i=i+2)
    {
        sum = sum+Array[i];
    }
    return sum;
}