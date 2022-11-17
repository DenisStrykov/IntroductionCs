



// Написать программу вычисления значения функции y = sin(a). (Класс Math).


System.Console.Write("Введите значение для вычисления функции y = sin(a): ");
double a = Convert.ToDouble(Console.ReadLine());
double y = Math.Sin(a);
System.Console.WriteLine(y);