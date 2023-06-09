//new Random().Next(min,max),[min, max-1] то есть если мне нужно число от 1 до 10, запись будет выглядеть так [1,9]\
int numberA = new Random().Next(1,10);
Console.Write("Первая цифра = ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.Write("Вторая цифра = ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("Сумма = ");
Console.WriteLine(result);
