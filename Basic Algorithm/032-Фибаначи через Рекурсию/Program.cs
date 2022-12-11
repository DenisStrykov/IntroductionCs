




// Решите уравнение Фибаначи через Рекурсию



int N = 10;
int c = 0;

while (c<=N)
{
    System.Console.Write($"{Fibonacci(c), 5}");
    c++;
}




int Fibonacci(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}