




using System.Security.AccessControl;
using System;
// Переменная типа Char - Символ (Хранит в себе один символ / UTF-16)



char a = 'A';
char b = 'b';

System.Console.WriteLine($"{a+b}"); // Будет показывать не склейку символов,а сумму сзначений их кодировки
System.Console.WriteLine(a.ToString()+b.ToString()); // А вот тут уже склейка символов
if (a>='0' && a<='9')
{
    System.Console.WriteLine($"({a}) это цифра");
}
if (a>='A' && a<='Z')
{
    System.Console.WriteLine($"({a}) это заглавная буква");
}
if (a>='a' && a<='z')
{
    System.Console.WriteLine($"({a}) это строчная буква");
}


string s = "sadcs"; // immutable string - неизменяемые строки
System.Console.WriteLine(s);
System.Console.WriteLine(s[0]); // можно обращаться к опр элементам, но присваивать элеентам массива другое - нельзя

char[] cc = s.ToCharArray();
cc[0] = 'S';                    // Вариант переброски букв в string
s = new String(cc);
System.Console.WriteLine(s);

System.Text.StringBuilder sb = new System.Text.StringBuilder(s);
sb[0] = 's';                    // Еще один вариант переброски букв в string
s = sb.ToString();
System.Console.WriteLine(s);

string s1 = "hello";
string s2 = "hello";
System.Console.WriteLine(s1 == s2); // True Сравнивается и ссылка памяти и ЗНАЧЕНИЕ

Random random1 = new Random();
Random random2 = new Random();
System.Console.WriteLine(random1 == random2); // А вот тут сравниваются только ссылки на объекты

System.Console.WriteLine(s1.Length); // // s1.Length - Длина строки

System.Console.WriteLine(s1.IndexOf("ll")); // Есть лимволы в строке

s1 = s1.Replace("ll", "rr");  // Меняет символы в строке
System.Console.WriteLine(s1);
char