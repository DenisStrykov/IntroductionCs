




// По двум заданным числам проверить: является ли одно квадратом другого.



System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a==b) System.Console.WriteLine($"Квадратом числа {a} является {b}");
else
    if (b*b==a) System.Console.WriteLine($"Квадратом числа {b} является {a}");
else System.Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");
