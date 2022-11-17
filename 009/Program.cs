



// Вывести на экран четные числа от 1 до N


System.Console.Write("Введите значение: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < n; i = i+2) {
    System.Console.WriteLine(i);
}