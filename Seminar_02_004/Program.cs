// Напишите программу, которая будет принимать на вход два целочисленных числа и
// выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число:");
string number1 = Console.ReadLine();
int a = int.Parse(number1);

Console.WriteLine("Введите первое число:");
string number2 = Console.ReadLine();
int b = int.Parse(number2);

Console.WriteLine("Является ли " + b + " кратным " + a + "?");

if(a%b==0)
{
    Console.WriteLine("Число кратное");
}
else
{
    Console.WriteLine("Число не кратное. Остаток деления = " + a%b);
}
