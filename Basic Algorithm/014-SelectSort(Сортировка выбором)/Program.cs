




// Сортировка выбором



int[] a = RandomIntArray(12, -50, 50);
Print(a);
int count = 0;
SelectSort(a, out count);
Print(a);
System.Console.WriteLine(count);

int[] RandomIntArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++)
    {
        arr[i] = random.Next(min, max+1);
    }
    return arr;
}

void Print(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        System.Console.Write($"{array[i], 5}");
    }
    System.Console.WriteLine();
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

void SelectSort(int[] a,out int count)
{
   count=0;
   int im;
   for(int i=0;i<a.Length;i++)
   {
        im=i;
        for(int j=i+1;j<a.Length;j++)
        {

            if (a[im]<a[j]) im=j;
            count++;
        }
        Swap(ref a[i],ref a[im]);
        
   }
}