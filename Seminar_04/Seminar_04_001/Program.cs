// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Метод принимающий число от пользователя
int GetNumber()
{
    Console.WriteLine("Введите пятизначное число:");
    int Num = Math.Abs(int.Parse(Console.ReadLine()));
    return Num;
}

// Метод, проверяющий число
bool IsNumberValid(int numA)
{
    if(numA<10000 || numA>100000)    
        return false;

    return true;
}

// Метод разворачивающий число
int ReverseNumber(int number)
{
    int RevNumber = 0;
    while (number > 0)
    {
        RevNumber = RevNumber * 10 + number % 10;
        number = number / 10;
    }
    return RevNumber;
}

// Проверка числа на палиндром
bool IsPalindrom(int value)
{
    int valueReverse = ReverseNumber(value);
    bool IsEqual = value == valueReverse;
    return IsEqual;
}


// Программа
int NumberA = GetNumber();
if (IsNumberValid(NumberA))
{
    if (IsPalindrom(NumberA))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("Wrong parameters");
}
