




// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

/*y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1*/

double k1 = ReadDouble("Задайте точку k1: ");
double b1 = ReadDouble("Задайте точку b1: ");
double k2 = ReadDouble("Задайте точку k2: ");
double b2 = ReadDouble("Задайте точку b1: ");
double x = 0;
double y = 0;

x = (b2 - b1)/(k1-k2);
y = k1*x+b1;
System.Console.WriteLine($"x={x}, y={y}");

double ReadDouble(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}