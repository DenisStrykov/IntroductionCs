




// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1



int N = ReadInt("Введите число N: ");
int[] a = new int[N];
a[0] = 0;
a[1] = 1;

for (int i=2; i<N; i++)
{
    a[i] = a[i-1] + a[i-2];
}

PrintArray(a);

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i], 5}");
    }
}
