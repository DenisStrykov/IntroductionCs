




// Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным.



System.Console.WriteLine("Введите день недели. Учтите, что понедельник - 1; вторник -2 и т.д.");
System.Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day==6 || day==7)
{
    System.Console.WriteLine($"Введенный вами номер дня ({day}) является выходным");
} else
{
    System.Console.WriteLine($"Введенный вами номер дня ({day}) не является выходным");
}

