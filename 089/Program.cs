




// Подсчитать сумму цифр, встречающихся в строке



string s = Console.ReadLine();

int sum = 0;

for (int i=0; i<s.Length; i++)
{
    if ((s[i]>='0') && (s[i]<='9'))
    {
        sum += s[i] - '0';
    }
}
System.Console.WriteLine(sum);