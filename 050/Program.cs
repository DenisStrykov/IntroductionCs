




// Выяснить являются ли три числа сторонами треугольника



System.Console.WriteLine("Привет! По заданным тобой параметрам, мы проверим, могут ли являетьмя числа сторонами треугольника :)");
double a = ReadDouble("Введите сторону стреугольника a: ");
double b = ReadDouble("Введите сторону стреугольника b: ");
double c = ReadDouble("Введите сторону стреугольника c: ");

if (IfTriangleDegrees(a, b, c))
{
    System.Console.WriteLine("Является");
} else
{
    System.Console.WriteLine("Не явлется");
}

double ReadDouble(string massege)
{
    System.Console.Write(massege);
    return Convert.ToDouble(Console.ReadLine());
}

bool IfTriangleDegrees(double a, double b, double c)
{
    return a+b>c && a+c>b && b+c>a;
}