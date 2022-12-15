






// Частотный словарь
// Составить частотный словарь элементов одномерного массива состоящих из чисел от 0 до 99


int size = ReadInt("Введите размер массива: ");
int min = ReadInt("Min: ");
int max = ReadInt("Max: ");
int[] data = RandomInt(size, min, max);
int[] freqArray = new int[100];

foreach (int element in data)
{
    freqArray[element]++;
}
for (int i=0; i<freqArray.Length; i++)
{
    if (freqArray[i] != 0)
    {
        System.Console.WriteLine($"{i} {freqArray[i]}");
    }
}



int ReadInt(string m)
{
    System.Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}

int[] RandomInt(int size, int min, int max)
{
    int[] d = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        d[i] = random.Next(min, max+1);
    }
    return d;
}