// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.


//Программа
Console.Clear();
string numA = GetValue("Введите число:");
bool IsAInt = IsNumberInt(numA);
if (IsAInt)
{
    int A = GetInt(numA);
    bool IsAValid = IsNumberValid(A);
    if (IsAValid)
    {
        ToBinary(A);

        string Zahl = ConvertToBinary(A);
        Console.WriteLine(Zahl + " - через рекурсию");

        string sysRes = Convert.ToString(A, 2);
        Console.WriteLine(sysRes + " - Результат системы");

    }
    else
    {
        Console.WriteLine("Ошибка");
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
bool IsNumberValid(int num)
{
    if (num >= 0)
        return true;
    return false;
}

// Метод перевода в двоичное число
void ToBinary(int Number)
{
    string result = "";
    int Rem;

    do
    {
        Rem = Number % 2;
        Number = Number / 2;
        result = Rem + result;
    }
    while (Number > 0);

    Console.WriteLine(result + " - через цикл do while");
}

// Конвертирование в двоичное число с использованием рекурсии
string ConvertToBinary(int Nummer)
{
    if (Nummer > 0) 
    return ConvertToBinary(Nummer / 2) + Nummer % 2;
    return "0";
}

