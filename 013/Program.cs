




// Удалить вторую цифру целого числа введенного с клавиатуры



System.Console.Write("Введите значение: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a/100*10+a%10;
System.Console.WriteLine($"Значение без второй цифры равно: {b}");