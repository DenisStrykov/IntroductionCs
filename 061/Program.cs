




// Показать двумерный массив размером m×n заполненный вещественными случайными числами



int n = ReadInt("Введите значение n: ");
int m = ReadInt("Введите значение m: ");

double[,] a = Random2DArray(n, m);
Print(a);



int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


double[,] Random2DArray(int n, int m)
{
    double[,] a = new double[n, m];
    Random random = new Random();
    for (int i=0; i<n; i++)
    {
        for (int j=0; j<m; j++)
        {
            a[i,j] = random.NextDouble();
        }
    }
    return a;
}

void Print(double[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
        {
            System.Console.Write($"({a[i,j], 5})");
        }
        System.Console.WriteLine();
    }
}