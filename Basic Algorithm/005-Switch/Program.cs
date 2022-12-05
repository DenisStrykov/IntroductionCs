




// С клавитатуры вводится число, обозначающий день недели. Определить день недели



int day = ReadInt("Введите номер дня: ");

switch (day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четсверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("Выберите день от 1 до 7");
        break;
}

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}