




// Дано число больше 9. Вывести на экран  вторую цифру числа с конца



System.Console.Write("Введите значение больше 9: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Вторая цифра числа с конца равна: ");
System.Console.WriteLine(a/10%10);