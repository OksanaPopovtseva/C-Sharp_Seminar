// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int a = int.Parse(number);

if (a % 23 == 0 && a % 7 == 0)
{
    Console.WriteLine("Число " + a + " кратно 7 и 23.");
}
else if (a % 23 == 0 )
{
    Console.WriteLine("Число " + a + " кратно 23, но не кратно 7.");
}
else if (a % 7 == 0 )
{
    Console.WriteLine("Число " + a + " кратно 7, но не кратно 23.");
}
else 
{
    Console.WriteLine("Число " + a + " не кратно ни 7, ни 23.");
}