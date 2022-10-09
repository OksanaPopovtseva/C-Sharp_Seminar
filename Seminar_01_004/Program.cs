// Пользователь вводит трехзначное число. Вывести последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число:");
string number1 = Console.ReadLine();
int x = int.Parse(number1);
int y = x / 10 * 10;
int z = x - y;
Console.Write("Последняя цифра введенного числа: ");
Console.Write(z);
