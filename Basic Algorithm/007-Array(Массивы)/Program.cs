


/*      100 104 108 112 116 120 124 128 132 136
         0   1   2   3   4   5   6   7   8   9                  & - индекс первой ячейкм
int a   [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]          a[3] = &100 + 3*4
         4   4   4   4   4   4   4   4   4   4                           4 - размер нитовой переменной (1 байт)
*/
// Рассчитать среднюю температуру за неделю


int n = 7;
double[] t = new double[n];      // Массиа - это !!!!ОБЪЕКТ!!!!
double s = 0;

for (int i=0; i<t.Length; i++)
{
    System.Console.Write("Введите температуру: ");
    t[i] = Convert.ToDouble(Console.ReadLine());
    s += t[i];
}
System.Console.WriteLine($"s={s/t.Length}");