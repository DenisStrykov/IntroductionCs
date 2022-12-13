




// Подсчитать количество цифр среди вводимых с клавиатуры символов



string s = ReadString("Введите символы: ");
int c = 0;

System.Console.WriteLine(Schet(c, s));




string ReadString(string m)
{
    System.Console.Write(m);
    return Console.ReadLine();
}

int Schet(int c, string s)
{
    for (int i=0; i < s.Length; i++)
    {
        if (char.IsDigit(s[i]))
        {
            c++;
        }
    }
    return c;
}