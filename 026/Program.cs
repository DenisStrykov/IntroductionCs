




// Найти сумму чисел от 1 до А



SayHello();
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"{FoundSum(n)}");


int FoundSum(int n)
{
    int sum = 0;
    for (int i = 1; i<n; i++)
    {
        sum = sum + i;
    } return sum;
}


void SayHello()
{
    System.Console.WriteLine("Привет! Мы найдем сумму числел от 1 до N");
}
