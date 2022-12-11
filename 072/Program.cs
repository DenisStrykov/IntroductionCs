




// Показать натуральные числа от M до N, N и M заданы



int M = ReadInt("Задайте число M: ");
int N = ReadInt("Задайте число N: ");
Number(N, M);

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