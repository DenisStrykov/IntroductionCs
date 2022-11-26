




// Проверить истинность утверждения !(x || y) == !x && !y



System.Console.WriteLine("Давай проверим истинность устверждения, что: !(x || y) == !x && !y");

System.Console.WriteLine("x  y    !(x || y)  !x && !y");
System.Console.WriteLine($"0  0        {Convert.ToInt32(!(false || false))}         {Convert.ToInt32(!false && !false)}");
System.Console.WriteLine($"0  1        {Convert.ToInt32(!(false || true))}         {Convert.ToInt32(!false && !true)}");
System.Console.WriteLine($"1  0        {Convert.ToInt32(!(true || false))}         {Convert.ToInt32(!true && !false)}");
System.Console.WriteLine($"1  1        {Convert.ToInt32(!(true || true))}         {Convert.ToInt32(!true && !true)}");