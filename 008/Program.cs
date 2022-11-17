




// Вывести на экран числа от -N до N



System.Console.Write("Введите значение: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = n*(-1); i<=n; i++) {
    System.Console.Write($"/ {i} ");
}