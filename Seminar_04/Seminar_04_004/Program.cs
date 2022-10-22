// 26: Напишите программу, которая принимает на вход число и
// выдает количество цифр в числе.
// Операции для типа string не использовать.


// Метод переводящий введенные данные в число
int GetNumber(string message)
{
    int a = Math.Abs(int.Parse(message));
    return a;
}

// Метод для проверки данных
bool IsInputValid(string input)
{
    int Num;
    bool isNum = Int32.TryParse(input, out Num);
    if (isNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метода для расчета количества цифр
int CalcDigits(int n)
{
    int count = 0;
    if (n == 0)
    {
        count = 1;
    }
    else
    {
        while (n > 0)
        {
            n = n / 10;
            count = count + 1;
        }
    }
    return count;
}

// Программа
Console.Clear();
Console.WriteLine("Введите число");
string value = Console.ReadLine();
bool IsNumber = IsInputValid(value);
if (IsNumber)
{
    int N = GetNumber(value);
    Console.Write($"В числе {N} количество цифр равно {CalcDigits(N)}");
}
else
{
    Console.WriteLine("Ошибка.Введите число");
}
// Console.WriteLine($"Количество цифр в числе: {calcLength(N)}");
