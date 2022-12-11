




// Показать натуральные числа от N до 1, N задано



int N = ReadInt("Задайте число N: ");
Number(N);

int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

void Number(int N)
{   
    if (N < 1)
    {
        return;
    }
    Console.Write($"{N, 5}");
    Number(N - 1);
}