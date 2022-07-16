Console.Write("Введите координату X:");
int x = Int32.Parse(System.Console.WriteLine());
Console.Write("Введите координату Y:");
int y = Convert.ToInt32(System.Console.WriteLine());
if(x>0 && y>0)
{
    System.Console.WriteLine("Четверть: 1");
}
else if(x<0 && y>0)
{
    System.Console.WriteLine("Четверть: 2");
}
else if(x<0 && y<0)
{
    System.Console.WriteLine("Четверть: 3");
}
else if(x>0 && y<0)
{
    System.Console.WriteLine("Четверть: 4");
}
else
System.Console.WriteLine("Введите коректно координаты");