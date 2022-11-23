




// Обмен значениями двух переменных



/* int a = 5;
int b = 7;

int c;
                                    Классический способ
c = a;
a = b;
b= c;

System.Console.WriteLine(a);
System.Console.WriteLine(b); */

int a =  5;
int b= 7;

a = a+b;
b = a-b;
a = a-b;

System.Console.WriteLine(a);
System.Console.WriteLine(b);