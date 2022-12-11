




// Вывести числа от 1 до N без использования цикла



/*int i = 1;
int N = 10;

metka:
    System.Console.WriteLine(i);
    i++;


if (i<=N)
{
    goto metka;
}*/



Loop(10, 1);

void Loop(int N, int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i, 5}");
        Loop(N, i+1); // Рекурсия - это когда мы внутри какой-то подпрограммы обращаемся к ней же
    }
}