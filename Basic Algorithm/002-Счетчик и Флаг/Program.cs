﻿




/*
Напишите программу для решения слудеющей задачи:
На контрольной работе по алгебре ученикам 9 класса было предложено 10 примеров. Неудовлетворительная оценка выставляется, если правилно 
решено менее половины примеров. Сколько неудовлетворительных оценок было получено учениками? Если хотя бы один из учеников проавильно решил все задачи,
выведите YES, иначе - выведите NO.
Программа получает на вход количество учеников в классе N (1 <= n <= 30),
затем для каждого ученика вводится количество правильно решенных примеров.
*/

int n = int.Parse(Console.ReadLine());
int k = 0;
bool flag = false;
for (int i=0; i<n; i++) 
{
    int a = int.Parse(Console.ReadLine());
    if (a<5) k++;
    if (a==10) flag = true;
}
System.Console.WriteLine(k);
if (flag) 
{
    System.Console.WriteLine("YES");
} else
{
    System.Console.WriteLine("NO");
}