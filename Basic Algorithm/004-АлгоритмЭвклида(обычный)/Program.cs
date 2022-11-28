




// Провстой Алгоритм Эвклида



System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a!=b)
{
    if (a>b)
    {
        a = a-b;
    } else
    {
        b = b-a;
    }
}

System.Console.WriteLine($"Наименьший общий делитель для введенных чисел: {a}");