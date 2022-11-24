




int n = Convert.ToInt32(Console.ReadLine());
int min = int.MaxValue; // int.MaxValue - максимальное значение интовой переменной...

for (int i=0; i<n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a<min && a%10==4)
    {
        min = a;
    }
}

System.Console.WriteLine(min);