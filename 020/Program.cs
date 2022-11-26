




// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0



System.Console.WriteLine("Введите координаты x и y");
System.Console.Write("Введите координаты оси x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты оси y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
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

    System.Console.WriteLine($"Координаты с введенными вами значениями {x} и {y} находятся в I четверти");

} else
{
    if (x>0 && y<0) 
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

        System.Console.WriteLine($"Координаты с введенными вами значениями {x} и {y} находятся в II четверти");
    } else
    {
        if (x<0 && y<0) 
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

        System.Console.WriteLine($"Координаты с введенными вами значениями {x} и {y} находятся в III четверти");
    } else
    {
       if (x<0 && y>0) 
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

        System.Console.WriteLine($"Координаты с введенными вами значениями {x} и {y} находятся в IV четверти");
    } else
    {
        System.Console.WriteLine("Координаты x и y не могут быть равны 0 по условию задачи");
    }
    }
    }
}