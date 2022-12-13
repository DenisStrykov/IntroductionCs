




// Подсчитать сколько раз определенный символ (например 'a') встречается в строке



string s = Console.ReadLine();

char c = 'a';

int howMach = 0;
foreach (char i in s)
{
    if (i == c)
    {
        howMach ++;
    }
}
System.Console.WriteLine(howMach);