// 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Метод для создания рандомного массива
int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    Random r = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

//Метод для расчета произведения пар элементов массива
int[] CalcAndPrint(int[] array1)
{
    if (array1.Length % 2 == 0)
    {
        int[] array2 = new int[array1.Length / 2];
        for (int i = 0; i < array1.Length / 2; i++)
        {
            array2[i] = array1[i] * array1[array1.Length - 1 - i];
        }
        return array2;
    }
    else
    {
        int[] array2 = new int[array1.Length / 2 + 1];
        for (int i = 0; i < array1.Length / 2; i++)
        {
            array2[i] = array1[i] * array1[array1.Length - 1 - i];
        }
        array2[array1.Length / 2] = array1[array1.Length / 2];
        return array2;
    }
}

//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("}");
}


//Программа
int N = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимум для элементов");
int max = GetNumber("Введите максимум для элементов");

int[] myArray = CreateRandomArray(N, min, max);
PrintArray(myArray);
Console.WriteLine();
int[] multiArray = CalcAndPrint (myArray);
PrintArray(multiArray);