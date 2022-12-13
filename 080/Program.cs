




// Вывести на экран кодировку символов по ASCII(с 32 до 122)



for (char c = '\x32'; c <= '\x122'; c++)
{
    System.Console.Write($"{c, 5}");
}