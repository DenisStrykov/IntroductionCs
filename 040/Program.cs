




// Задан массив Array из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве Array. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


System.Console.Write("Укажите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = RandomIntArray(N, 1, 10);
Print(Array);

int c = Array.Length - 1;
for (int i = 0; i < (Array.Length + 1) / 2; i++)
{
    Console.Write($"{Array[i] * Array[c], 5}");
    c--;
}

int[] RandomIntArray(int size, int min, int max)
{
    int[] ar = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        ar[i] = random.Next(min, max+1);
    }
    return ar;
}

void Print(int[] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        System.Console.Write($"{Array[i], 5}");
    }
    System.Console.WriteLine();
}