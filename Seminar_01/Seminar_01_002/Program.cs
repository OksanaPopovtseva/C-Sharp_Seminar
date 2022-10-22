// Вывести название дня недели в зависимости от введенного пользователем числа

Console.WriteLine("Введите число от 1 до 7:");
string number1 = Console.ReadLine();
int x = int.Parse(number1);
if(x<1)
{
        Console.WriteLine("Ошибка. Введите число от 1 до 7");
}
else if(x>7)
{
        Console.WriteLine("Ошибка. Введите число от 1 до 7");
}
else if(x==1)
{
        Console.WriteLine("День недели - Понедельник");
}
else if(x==2)
{
        Console.WriteLine("День недели - Вторник");
}
else if(x==3)
{
        Console.WriteLine("День недели - Среда");
}
else if(x==4)
{
        Console.WriteLine("День недели - Четверг");
}
else if(x==5)
{
        Console.WriteLine("День недели - Пятница");
}
else if(x==6)
{
        Console.WriteLine("День недели - Суббота");
}
else if(x==7)
{
        Console.WriteLine("День недели - Воскресенье");
}