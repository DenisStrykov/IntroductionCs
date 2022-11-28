




// Вывести на экран кубы чисел от 1 до N



System.Console.WriteLine("Привет, мы возведем все числа в куб от еденицы до N");
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int b = 0;
for (int i=0; i<N; i++)
{
    b = (i+1)*(i+1)*(i+1);
    System.Console.WriteLine($"{i+1} в кубе равно: {b}");
}