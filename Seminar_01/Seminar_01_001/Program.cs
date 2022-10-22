// Попросить пользователя ввести два числа. 
// Опеределить, является ли первое число квадратным корнем второго.

Console.WriteLine("Введите число 1:");
string number1 = Console.ReadLine();
int x1 = int.Parse(number1);
Console.WriteLine("Введите число 2:");
string number2 = Console.ReadLine();
int x2 = int.Parse(number2);

if(x1 == x2 * x2)
{
    Console.Write(x1);
    Console.Write(" является квадратным корнем из ");
    Console.Write(x2);
}
else
{
    Console.Write(x1);
    Console.Write(" не является квадратным корнем из ");
    Console.Write(x2);
}