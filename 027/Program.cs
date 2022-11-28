




// Возведите число А в натуральную степень B используя цикл



int numberA = ReadInt("Введите значение a: ");
int numberB = ReadInt("Введите значение b: ");

int result = Degrading(numberA, numberB);

System.Console.WriteLine($"{numberA} в {numberB} степени равно: {result}");








int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Degrading(int a, int b)
{
    int result = 0;
    for (int i=1; i<=b; i++)
    {
        result = Convert.ToInt32(Math.Pow(a, i));
    }
    return result;
}