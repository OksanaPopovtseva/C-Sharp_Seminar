// 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Программа
int n = GetNumber("Введите количество строк");
int m = GetNumber("Введите количество столбцов");
bool IsValidN = IsInputValue(n);
bool IsValidM = IsInputValue(m);

if (IsValidN && IsValidM)
{
    int[,] myMatrix = CreateRandomMatrix(n, m, -5, 5);
    Console.WriteLine("Исходный массив:");
    PrintMatrix(myMatrix);
    Console.WriteLine();
    
    ChangeEvenPositionsToSquare(myMatrix);
    Console.WriteLine("Изменённый массив:");
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

// Метод для замены элементов на четных позициях на их квадраты
void ChangeEvenPositionsToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
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