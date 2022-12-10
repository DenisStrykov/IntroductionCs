




// Написать программу копирования массива



int N = ReadInt("Из скольки чисел будет сстоять массив? ");
int[] a = RandomArray(N);
Print(a);
int[] aCopy = new int[N];

for (int i=0; i<N; i++)
{
    aCopy[i] = a[i];
}

Print(aCopy);



int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] RandomArray(int size)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        arr[i] = random.Next(-10, 10);
    }
    return arr;
}

void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    {
        System.Console.Write($"{a[i], 5}");
    }
    System.Console.WriteLine();
}