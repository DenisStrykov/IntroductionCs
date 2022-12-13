




// Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа



string number = Console.ReadLine();
int t = 0;
if (!Int32.TryParse(number, out t))
{
    System.Console.WriteLine("Not number");
} else
{
    int sum = 0;
    foreach (char d in number)
    {
        sum += d-48;
    }
    System.Console.WriteLine(sum);
}