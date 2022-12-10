




// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"


double[] a1 = new double[4];
double[] a2 = new double[4];

a1[0] = 0;
a1[1] = 2;
a1[2] = 2;
a1[3] = 0;

a2[0] = 0;
a2[1] = 0;
a2[2] = 2;
a2[3] = 2;

Print(a1, a2);

double k = ReadDouble("Введите множитель k: ");

for (int i=0; i<a1.Length; i++)
{
    a1[i] = a1[i]*k;
    a2[i] = a2[i]*k;
}

Print(a1, a2);



void Print(double[] a1, double[] a2)
{
    for(int i=0; i<a1.Length; i++)
    {
        System.Console.Write($"({a1[i]},{a2[i]}) ");
    }
    System.Console.WriteLine();
}

double ReadDouble(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}