




// Написать программу вычисления функции Аккермана



System.Console.WriteLine("Найдем функции Аккермана A(m,n)");
int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");

System.Console.WriteLine(Accrement(m, n));


int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

int Accrement(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    } else if (n == 0)
    {
        return Accrement(m-1, 1);
    } else
    {
        return Accrement(m-1, Accrement(m, n-1));
    }
}