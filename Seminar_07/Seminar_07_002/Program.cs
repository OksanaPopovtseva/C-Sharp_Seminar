// 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// Программа
int n = GetNumber("Введите количество строк");
int m = GetNumber("Введите количество столбцов");
bool IsValidN = IsInputValue(n);
bool IsValidM = IsInputValue(m);

if(IsValidN && IsValidM)
{
int[,] myMatrix = GetMatrix(n,m);
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

// Метод для создания двумерного массива
int[,] GetMatrix (int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = i+j;
        }
    }
    return matrix;
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