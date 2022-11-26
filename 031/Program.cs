




// Сгенерировать 10 случайных чиселю. Показать кубы тех чисел,которые заканчивающихся на четную цифру



Random random = new Random();
for (int i=0; i<10; i++)
{
    int a = random.Next(1, 100);
    int b = (int)Math.Pow(a, 3);
    if (Test(b))
    {
    System.Console.WriteLine($"{a}, {b}");
    }
}

bool Test(int number)
{
    /* if (number%2 == 0)
    {
        return true;
    } else
    {
        return false;
    }*/
    return number%2 == 0;
}