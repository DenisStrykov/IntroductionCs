




// 



int a = 3;
int b = 5;
int sum = 0;
int mult = 0;

Calculator(a, b, ref sum, ref mult);
System.Console.WriteLine($"sum={sum} mult={mult}");

System.Console.WriteLine($"a={a} b={b}");               // После применения модификатора ref, в стэк уйдет уже не ссылка на значения a и b,
Swap(ref a,ref b);                                      // а уйдет номер ячейки, в которой хранится a и b
System.Console.WriteLine($"a={a} b={b}");               // Используй модификатор out,если не хочешь присваивать значение переменной сразу, а хочешь, чтобы присваивание 
                                                        // происходило в теле метода, и чтобы он возвращал какое-либо значение


void Swap(ref int a, ref int b)
{
    int c;
    c = a;                                              // a=3 b=5
    a = b;                                              // a=5 b=3
    b = c;
}
// чтобы через метод вернуть несколько значений, можем воспользоваться модификатором ref
void Calculator(int a, int b, ref int sum, ref int mult)
{
    sum = a+b;
    mult = a*b;
}

/*
void Swap(int a, int b)
{
    int c;
    c = a;                      без модификатора ref метод будет использовать ссылочные данные на переменные a и b              a=3 b=5
    a = b;                      поэтому значения на выходе после мктода не меняются, ссылочные данные исчезают в стэке...       a=3 b=5
    b = c;
} */