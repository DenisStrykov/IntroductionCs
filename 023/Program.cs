




// Найти расстояние между точками в пространстве 2D



System.Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату y1: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double distance;

distance = Math.Sqrt((x2-x1)*(x2-x1)+Math.Pow(y2-y1, 2)); //Math.Sqrt - функция квадратного корня / Math.Pow - первый аргумент - что, второй - в какую степень

System.Console.WriteLine($"Расстояние между точками в пространстве равно: {distance}");