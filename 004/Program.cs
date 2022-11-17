




// По заданному с клавиатуры номеру дня недели вывести его название



System.Console.Write("Введите номер дня недели от 1 до 7: ");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberOfWeek == 1) {
    System.Console.WriteLine("1 день - Понедельник");
} else if (numberOfWeek == 2) {
    System.Console.WriteLine("2 день - Вторник");
} else if (numberOfWeek == 3) {
    System.Console.WriteLine("3 день - Среда");
} else if (numberOfWeek == 4) {
    System.Console.WriteLine("4 день - Четверг");
} else if (numberOfWeek == 5) {
    System.Console.WriteLine("5 день - Пятница");
} else if (numberOfWeek == 6) {
    System.Console.WriteLine("6 день - Суббота");
} else if (numberOfWeek == 7) {
    System.Console.WriteLine("7 день - Воскресенье");
} else {
    System.Console.WriteLine("Вы ввели значение не в диапазоне от 1 до 7");
}