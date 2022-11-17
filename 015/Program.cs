




// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)



System.Console.Write("Введите целое число > 99 и < 1000: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>99 & a<1000) {
    int b = a-(a/10*10);
    System.Console.WriteLine($"Третья цифра числа {a} = {b}");
} else {
    System.Console.WriteLine("NO");
}