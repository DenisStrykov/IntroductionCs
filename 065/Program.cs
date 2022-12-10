




// Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. 
// Если элемент отсутствует, подпрограмма возвращает -1.


int min = ReadInt("Введите значение min: ");
int max = ReadInt("Введите значение max: ");
int n = ReadInt("Введите значение n: ");
int m = ReadInt("Введите значение m: ");

int[,] a = Random2DArray(n, m, min, max);

Print(a);

int i;
int j;
int find = ReadInt("Введите значение find: ");
if (LineSrearch2DArray(a, find, out i, out j))
{
    System.Console.WriteLine($"Элемент {find} найден в массиве a({i},{j})");
} else
{
    System.Console.WriteLine($"Элемент {find} не найден");
}



int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Random2DArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i=0; i<n; i++)
    {
        for (int j=0; j<m; j++)
        {
            a[i,j] = random.Next(min, max+1);
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

bool LineSrearch2DArray(int[,] a, int find, out int i, out int j)
{
    for (i=0; i<a.GetLength(0); i++)
    {
        for (j=0; j<a.GetLength(1); j++)
        {
            if (a[i,j] == find)
            {
                return true;
            }
        }
    }
    j = -1; // Нужно просто, чтбы не ругался на невозможный выход
    return false;
}