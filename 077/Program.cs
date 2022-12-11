




// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности 0 и 1


int N = ReadInt("Задайте число N: ");
int c = 0;

while (c<=N)
{
    System.Console.Write($"{Fibonacci(c), 5}");
    c++;
}


int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

int Fibonacci(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}