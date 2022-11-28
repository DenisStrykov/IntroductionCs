




// Подсчитать сумму цифр в числе. Сделать подпрограмму



SayHello();
int number = ReadInt("Введите число: ");

int sum = SumOfNumbers(number);

System.Console.WriteLine($"Сумма цифр в числе {number} равна: {sum}");

void SayHello()
{
    System.Console.WriteLine("Привет! Мы посчитаем сумму цифр в числе, которое ты введешь :)");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int n)
{
    int s = 0;
    while (n>0)
    {
        s = s + n%10;
        n = n/10;
    }
    return s;
}