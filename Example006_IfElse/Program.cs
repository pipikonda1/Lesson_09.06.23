Console.WriteLine("Введите своё имя: ");//WriteLine - в конце перейти на новую строку
string username = Console.ReadLine();//ReadLine - считать строку из терминала

if (username.ToLower == "Киса")
{
    Console.WriteLine("Доброго времени суток, кис)");
}
else
{
Console.Write("Привет, "); //Write - вывод в одну строку
Console.WriteLine(username);
}