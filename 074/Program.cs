




// Найти сумму цифр числа



int n = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр числа {n} = {Sum(n)}");





int ReadInt(string m)
{
    System.Console.WriteLine(m);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int n)
{
    if (n < 1)
    {
        return 0;
    } else
    {
        return Sum(n/10) + n%10;
    }
}