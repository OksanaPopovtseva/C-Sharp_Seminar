// Напишите программу, которая на вход принимает число (А) и
// выдает сумму чисел от 1 до А

// Метод, проверяющий входные данные
bool IsValid(int a)
{
    if (a <= 1)
        return false;
    return true;
}

int CalcSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

// Программа
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
bool InputValid = IsValid(A);
if (InputValid)
{
    int Sum=CalcSum(A);
    Console.WriteLine($"Сумма равна {Sum}");
}
else
{
    Console.WriteLine("Неправильные данные");
}