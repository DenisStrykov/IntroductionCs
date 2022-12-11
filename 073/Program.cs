




// Найти сумму элементов от M до N, N и M заданы



int M = ReadInt("Задайте число M: ");
int N = ReadInt("Задайте число N: ");

System.Console.WriteLine(Sum(M, N));  

int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int m, int n)
{
    if (m == n)
    {
        return m;
    } else
    {
        return Sum(m+1, n) + m; 
    }
}