// Пользователь вводит число N. Вывести все целые числа от -N до N

Console.WriteLine("Введите число:");
string number1 = Console.ReadLine();
int x = int.Parse(number1);
int y = x*(-1);

while(y<x)
{
    Console.Write(y);
    Console.Write(",");
    y = y + 1;
}
Console.Write(x);