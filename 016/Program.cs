




// Дано число, проверить, кратно ли оно 7 и 23



System.Console.Write("Введите число для проверки: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n%7==0)
{
    if (n%23==0)
    {
        System.Console.WriteLine($"Введенное вами число {n} кратно 7 и кратно 23");
    }
} else
{
    System.Console.WriteLine($"Введенное вами число {n} не кратно 7 и не кратно 23");
}