// 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// Программа
int n = GetNumber("Введите количество строк");
int m = GetNumber("Введите количество столбцов");
bool isNValid = IsInputValue(n);
bool isMValid = IsInputValue(m);

if(isNValid && isMValid)
{
int[,] myMatrix = CreateMatrix(n, m, -10, 10);
PrintMatrix(myMatrix);
}
else
{
    Console.WriteLine("Ошибка");
}

// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Метод для проверки введенного значения
bool IsInputValue(int number)
{
    if (number <= 0)
        return false;
    return true;
}

// Метод для создания двумерного массива, заполненного рандомно
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] a = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            a[i, j] = new Random().Next(min, max);
        }
    }
    return a;
}

// Метод для печати двумерного массива
void PrintMatrix(int[,] bMatrix)
{
    for (int i = 0; i < bMatrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < bMatrix.GetLength(1); j++)
        {
            Console.Write($"{bMatrix[i, j]} | ");
        }
        Console.WriteLine();
    }
}