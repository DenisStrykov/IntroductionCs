




// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int[] Array = RandomIntArray(123, -100, 100);
int searchNumber = FindNumber(Array);
System.Console.WriteLine($"Количество чисел в данном массиве в диапазоне от 10 до 99 равно: {searchNumber}");


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

int FindNumber(int[] Array)
{
    int count = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]>=10 && Array[i]<=99)
        count = count+1;
    }
    return count;
}