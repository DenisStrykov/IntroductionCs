




// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа



System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int firstNumber = a/10;
int secondNumber = a%10;

if (firstNumber>secondNumber) {
    System.Console.WriteLine($"Наибольшая цифра числа {a}: {firstNumber}");
} else {
    System.Console.WriteLine($"Наибольшая цифра числа {a}: {secondNumber}");
}