




// Вывести на экран последнюю цифру целого числа введенного с клавиатуры



System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a-(a/10*10);
System.Console.WriteLine(b);