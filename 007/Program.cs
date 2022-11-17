




// Выяснить является ли число чётным



System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0) {
    System.Console.WriteLine($"Число {a} действительно четное");
} else {
    System.Console.WriteLine($"Число {a} не четное");
}