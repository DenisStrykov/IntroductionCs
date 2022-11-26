




// Определить количество цифр в числе. Сделать подпрограмму.



System.Console.Write("Введите число, чтобы мы могли подсчитать, из скольких цифр оно состоит: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введенное вами число состоит из {NumericCounter(number)} цифр(ы)");


int NumericCounter(int Number)
{
    Number = Math.Abs(Number); // Math.Abs() - откидывает - у числа, приводя его в положительное значение (*(-1))
    int count = 0;
    if (Number==0)
    {
        count = 1;
    }
    while (Number>0)
    {
        Number = Number/10;
        count++;
    }
    return count;
}