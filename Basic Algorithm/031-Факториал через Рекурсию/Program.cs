




// Найти Факториал числа N с помощью Рекурсии


int N = 5;
System.Console.WriteLine($"Факториал числа {N} равен {Factorial(N)}");


int Factorial(int N)
{
    if (N==0)
    {
        return 1;
    } else
    {
        return Factorial(N-1)*N;
    }
}