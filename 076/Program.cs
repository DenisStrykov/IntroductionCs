




// Написать программу возведения числа А в целую степень B



int A = ReadInt("Введите число: ");
int B = ReadInt("В какую степень его возводим? ");

System.Console.WriteLine(Stepen(A, B));



int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

int Stepen(int a, int b)
{
    if (b < 1)
    { 
        return 1;
    } else
    {
        return Stepen(a, b-1) * a;
    }
}