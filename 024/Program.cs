




// Вывести на экран таблицу квадратов чисел от 1 до N



SayHello();

System.Console.WriteLine("Привет, мы возведем все числа в квадрат от еденицы до N");
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int b = 0;
for (int i=0; i<N; i++)
{
    b = (i+1)*(i+1);
    System.Console.WriteLine($"{i+1} в квадрате равно: {b}");
}




void SayHello()
{
    System.Console.WriteLine("Привет!");
    System.Console.WriteLine("Благдаю за ваши занятия!!");
    System.Console.WriteLine("Смотреть ваши семинари одно удовольствие");
    System.Console.WriteLine("Спешу использовать на практике полученные знания!");
}