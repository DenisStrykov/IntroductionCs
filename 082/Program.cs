




// C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки



string s = Console.ReadLine();

char ch = '.';
int indexOfChar = s.IndexOf(ch);

System.Console.WriteLine(indexOfChar);