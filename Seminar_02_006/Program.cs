// Напишите программу, которая принимает на вход два в числа и
// проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число:");
string number1 = Console.ReadLine();
int a = int.Parse(number1);

Console.WriteLine("Введите первое число:");
string number2 = Console.ReadLine();
int b = int.Parse(number2);

if (Math.Pow(a,2)==b || Math.Pow(b,2)==a) 
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число НЕ является квадратом другого");
}