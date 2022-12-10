




// Написать программу преобразования десятичного числа в двоичное



System.Console.WriteLine("Привет! Мы переведем введенное тобой число из десятичной системы исчисления в двоичную ;)");
int number = ReadInt("Введите число: ");
string s = "";
if (number == 0)
{
    System.Console.WriteLine("0");
} else
{
    System.Console.WriteLine($"В двоичной это: {BeeNar(number, s)}");
}

int ReadInt(string massege)
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

string BeeNar(int number, string s)
{
    while (number != 0) 
    {
        s = (number%2)+s;
        number /= 2;
    }
    return s;
}