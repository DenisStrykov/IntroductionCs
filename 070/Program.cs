




// Показать натуральные числа от 1 до N, N задано



int N = ReadInt("Задайте число N: ");
Number(N, 1);

int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

void Number(int n, int i)
{
    if (i <= n)
    {
        System.Console.Write($"{i, 5}");
        Number(N, i+1);
    }
}