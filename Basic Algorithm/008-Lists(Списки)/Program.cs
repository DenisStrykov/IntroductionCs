




// Рассчитать среднюю температуру за неделю


                                // Особенность в том,что можно легко добавлять, или удалять элементы (он динамичен), но они медленнее массивов
List<int> t = new List<int>(); // В отличии от массива они не создаются заранее
double s = 0;

for (int i=0; i<7; i++)
{
    t.Add(Convert.ToInt32(Console.ReadLine()));
}
for (int i=0; i<7; i++)
{
    s = s + t[i];
}

System.Console.WriteLine(s/t.Count);