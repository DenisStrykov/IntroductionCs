




// Написать программу вычисления произведения чисел от 1 до N



SayHello();

int number = ReadInt("Введи число N: ");
int factorial = Factorial(number);

System.Console.WriteLine(factorial);

void SayHello()
{
    System.Console.WriteLine("Привет! Мы вычислим произведения всех чисел от 1 до N :)");
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int f)
{
    int sum = 1;
    for (int i=1; i<=f; i++)
    {
        sum *= i; 
    }
    return sum;
}