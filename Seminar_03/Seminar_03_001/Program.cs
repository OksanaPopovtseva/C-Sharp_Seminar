// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int GetValue (string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int x = GetValue("Введите координату x");
int y = GetValue("Введите координату y");

if (x>0 && y>0)
{
    Console.WriteLine("Четверть 1");
}
else if (x<0 && y>0)
{
    Console.WriteLine("Четверть 2");
}
else if (x<0 && y<0)
{
    Console.WriteLine("Четверть 3");
}
else if (x>0 && y<0)
{
    Console.WriteLine("Четверть 4");
}
else
{
    Console.WriteLine("Ошибка");
}