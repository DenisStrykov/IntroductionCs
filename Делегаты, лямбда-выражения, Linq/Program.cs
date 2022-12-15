




using System;
// Подсчитать сумму цифр, встречающихся в строке



// string s = "12345";

// int sum = s.ToCharArray().Cast<int>().Sum();
// System.Console.WriteLine(sum);


// Делеганты


// int CountDigits(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (char.IsDigit(c))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int CountLatin(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (c>='A' && c<='Z' || c>='a' && c<='z')
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int CountRus(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё')
//         {
//             count++;
//         }
//     }
//     return count;
// }

using System.Linq;  // Linq (Строчка необязательна, используется по умолчанию (это язык в языке...))

delegate bool IsChar(char c); // Сигнатура функции

class Program
{

static void Main()
{

    string s = "Эта строка содержит latinskie буквы и цифры (12345)";

    // Linq

    var queary = (from c in s where (c>='A' && c<='Z' || c>='a' && c<='z') select c).Count();
    var sum = (from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum();
    System.Console.WriteLine($"Изучи отдельно var и Linq = {sum}");

    // => Делегаты
    // Action
    // Func

    System.Console.WriteLine($"Latin = {CountChars(s, IsLatin)}");
    System.Console.WriteLine($"Rus = {CountChars(s,(c)=>c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё')}"); // => Лямбда выражение
    System.Console.WriteLine($"Digit = {CountChars(s, char.IsDigit)}");  // Можно передавать готовые (char.IsDigit )
    
    


}

static int CountChars(string s, IsChar IsChar)
{
    int count = 0;
    foreach (char c in s)
    {
        if (IsChar(c))
        {
            count++;
        }
    }
    return count;
}

static bool IsLatin(char c)
{
    return (c>='A' && c<='Z' || c>='a' && c<='z');
}

static bool IsRus(char c)
{
    return (c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё');
}

}