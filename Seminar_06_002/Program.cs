// 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник со сторонами такой длина.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

//Программа
Console.Clear();
string sideA = GetValue("Введите длину первой стороны треугольника:");
string sideB = GetValue("Введите длину второй стороны треугольника:");
string sideC = GetValue("Введите длину третьей стороны треугольника:");
bool IsAInt = IsNumberInt(sideA);
bool IsBInt = IsNumberInt(sideB);
bool IsCInt = IsNumberInt(sideC);

if (IsAInt && IsBInt && IsCInt)
{
    int A = GetInt(sideA);
    int B = GetInt(sideB);
    int C = GetInt(sideC);
    bool IsAValid = IsLenghtValid(A);
    bool IsBValid = IsLenghtValid(B);
    bool IsCValid = IsLenghtValid(C);

    if (IsAValid && IsBValid && IsCValid)
    {
        bool IsTriangle = IsTriangleExcist(A, B, C);
        if(IsTriangle)
        {
            Console.WriteLine($"Треугольник со сторонами {A}, {B} и {C} существует");
        }
        else
        {
            Console.WriteLine($"Треугольника со сторонами {A}, {B} и {C} НЕ существует");
        }

    }
    else
    {
        Console.WriteLine("Ошибка. Сторона треугольника должна быть больше нуля");
    }
}
else
{
    Console.WriteLine("Неверные данные");
}


// Метод для считывания строки
string GetValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

//Метод для проверки числа int
bool IsNumberInt(string valueB)
{
    int Exp2;
    bool IsIntNum = Int32.TryParse(valueB, out Exp2);
    if (IsIntNum)
        return true;
    return false;
}

//Метод для перевода числа
int GetInt(string mess)
{
    int num = int.Parse(mess);
    return num;
}

//Метод для проверки длины массива
bool IsLenghtValid(int num)
{
    if (num > 0)
        return true;
    return false;
}

// Метод для проерки существования треугольника
bool IsTriangleExcist(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
        return true;
    return false;
}