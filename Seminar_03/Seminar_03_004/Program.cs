// Напишите программу, которая принимает на вход  целочисленное число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Метод для ввода и принятия числа
int GetValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int x = Convert.ToInt32(value);
    return x;
}

//Программа
int A = GetValue("Введите число:");

if (A > 0)
{
    for (int i = 1; i <= A; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}
else if (A < 0)
{
    for (int i = A; i < 0; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}
else
{
    Console.WriteLine("Ошибка");
}