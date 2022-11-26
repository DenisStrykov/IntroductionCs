




// Задать номер четверти, показать диапазоны для возможных координат



System.Console.WriteLine("Задайте номер четверти в системе координат, выбирете четрверть: 1 - I / 2 - II / 3 - III / 4 - IV: ");
int numberOfQuarter = Convert.ToInt32(Console.ReadLine());

if (numberOfQuarter == 1)
{
    
    System.Console.WriteLine("   IV   y ↑      I   ");
    System.Console.WriteLine("          |          ");
    System.Console.WriteLine("          |     *    ");
    System.Console.WriteLine("          |          ");
    System.Console.WriteLine("----------+--------->");
    System.Console.WriteLine("          |        x ");
    System.Console.WriteLine("          |          ");
    System.Console.WriteLine("          |          ");
    System.Console.WriteLine("  III     |     II   ");

    System.Console.WriteLine("Диапазон для возможных координат выбранной вами четверти: x>0 и y>0");

} else
{
    if (numberOfQuarter == 2) 
    {
        System.Console.WriteLine("   IV   y ↑      I   ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("----------+--------->");
        System.Console.WriteLine("          |        x ");
        System.Console.WriteLine("          |     *    ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("  III     |     II   ");

        System.Console.WriteLine("Диапазон для возможных координат выбранной вами четверти: x>0 и y<0");
    } else
    {
        if (numberOfQuarter == 3) 
    {
        System.Console.WriteLine("   IV   y ↑      I   ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("----------+--------->");
        System.Console.WriteLine("          |        x ");
        System.Console.WriteLine("   *      |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("  III     |     II   ");

        System.Console.WriteLine("Диапазон для возможных координат выбранной вами четверти: x<0 и y<0");
    } else
    {
       if (numberOfQuarter == 4) 
    {
        System.Console.WriteLine("   IV   y ↑      I   ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("   *      |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("----------+--------->");
        System.Console.WriteLine("          |        x ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("          |          ");
        System.Console.WriteLine("  III     |     II   ");

        System.Console.WriteLine("Диапазон для возможных координат выбранной вами четверти: x<0 и y>0");
    } else
    {
        System.Console.WriteLine("Введенный вами номер четверти не существует");
    }
    }
    }
}