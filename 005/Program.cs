




// С клавиатуры вводятся три числа. Найти максимальное из трех чисел



System.Console.Write("Введите 1 число: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 3 число: ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;

if (max<b) {
    max = b;
} 
if (max<c) {
    max = c;
} 

System.Console.WriteLine($"Максимальное из трех чисел равно: {max}");