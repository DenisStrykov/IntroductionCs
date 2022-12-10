




// Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: 
// Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива


int min = ReadInt("Введите значение min: ");
int max = ReadInt("Введите значение max: ");
int n = ReadInt("Введите значение n: ");
int m = ReadInt("Введите значение m: ");

int[,] a = Create2DArray(n, m, min, max);

Print(a);



int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    for (int i=0; i<n; i++)
    {
        for (int j=0; j<m; j++)
        {
            a[i,j] = i+j;
        }
    }
    return a;
}

void Print(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j], 5}");
        }
        System.Console.WriteLine();
    }
}