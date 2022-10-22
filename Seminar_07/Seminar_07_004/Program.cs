// 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//// Программа
int n = GetNumber("Введите количество строк");
int m = GetNumber("Введите количество столбцов");
bool IsValidN = IsInputValue(n);
bool IsValidM = IsInputValue(m);

if (IsValidN && IsValidM)
{
    int[,] myMatrix = CreateRandomMatrix(n, m, -10, 10);
    Console.WriteLine("Исходный массив:");
    PrintMatrix(myMatrix);
    Console.WriteLine();

    int sumElements = DiagonalSum(myMatrix);
    Console.WriteLine($"Сумма элементов на диагонали = {sumElements}");
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

// Метод для создания рандомного двумерного массива
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
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
        for (int j = 0; j < bMatrix.GetLength(1); j++)
        {
            Console.Write($"{bMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для расчета суммы элементов на главной диагонали
int DiagonalSum(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                summ = summ + array[i, j];
            }
        }
    }
    return summ;
}