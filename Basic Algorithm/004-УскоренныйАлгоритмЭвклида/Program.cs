




// Ускоренный Алгоритм Эвклида



int GCD(int a, int b)
{
    while (a!=0 && b!=0)
    {
        if (a>b)
        {
            a = a%b;
        } else
        {
            b = b%a;
        }
    }
    return a+b;
}

System.Console.WriteLine(GCD(88,5000));