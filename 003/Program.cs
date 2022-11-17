




// С клавиатуры вводятся два числа a и b. Найти максимальное из них



System.Console.Write("Введите 1 чило: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 чило: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a>b) {
    System.Console.WriteLine($"Наибольшее из двух чисел: {a}");
} else {
    System.Console.WriteLine($"Наибольшее из двух чисел: {b}");
}