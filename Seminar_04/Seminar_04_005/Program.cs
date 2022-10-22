// 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N

//Метод на принятие числа
int GetNum()
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

//Метод для проверки данных
bool IsNumberValid(int A)
{
    if (A == 0)
        return false;

    return true;
}

//Метод для вычисления произведения
int Multiplier(int B)
{
    int multValue = 1;
    if (B > 0)
    {
        for (int i = 1; i <= B; i++)
        {
            multValue = multValue * i;
        }
    }
    else
    {
        for (int i = B; i < 0; i++)
        {
            multValue = multValue * i;
        }
    }
    return multValue;
}

//Программа
int N = GetNum();
bool IsNum = IsNumberValid(N);
if (IsNum)
{
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {Multiplier(N)}");
}
else
{
    Console.WriteLine("Ошибка");
}