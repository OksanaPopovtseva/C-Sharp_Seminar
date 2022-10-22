// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.
// Для одномерного и двумерного массива.

//Программа
Console.Clear();
int N = GetNumber("Введите длину массива");
if (N > 0)
{
    int[] MyArray = CreateRandomArray(N);
    PrintArray(MyArray);
    Console.WriteLine(" - изначальный массив");

    int[] CopyMyArray = CopyArray(MyArray);
    PrintArray(CopyMyArray);
    Console.WriteLine(" - скопированный массив");

    int[,] MyMatrix = CreateRandomMatrix(5, 5);
    Console.WriteLine("Двумерный массив исходный:");
    PrintMatrix(MyMatrix);

    int[,] CopyMyMatrix = CopyMatrix(MyMatrix);
    Console.WriteLine("Двумерный массив скопированный:");
    PrintMatrix(CopyMyMatrix);
}
else
{
    Console.WriteLine("Ошибка.");
}



// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Метод для создания рандомного одномерного массива
int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    Random r = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = r.Next(0, 100);
    }
    return array;
}

//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

// Метод для копирования массива
int[] CopyArray(int[] arr2)
{
    int[] copyArr2 = new int[arr2.Length];
    for (int i = 0; i < arr2.Length; i++)
    {
        copyArr2[i] = arr2[i];
    }
    return copyArr2;
}

//Метод для создания рандомного двумерного массива
int[,] CreateRandomMatrix(int n, int m)
{
    int[,] RanMatrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            RanMatrix[i, j] = rnd.Next(10, 100);
        }

    }
    return RanMatrix;
}

//Метод для печати двумерного массива
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

//Метод для копирования двумерного массива
int[,] CopyMatrix(int[,] matr2)
{
    int[,] CopyMatr = new int[matr2.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            CopyMatr[i, j] = matr2[i, j];
        }

    }
    return CopyMatr;
}