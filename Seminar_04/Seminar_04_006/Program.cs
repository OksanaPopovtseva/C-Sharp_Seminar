// 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//Метод для заполнения массива случайными 0 и 1
void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(0, 2);
    }
}

// Метод для печати массива
void PrintArray(int[] ArrB)
{
    Console.Write("[ ");
    for (int j = 0; j < ArrB.Length-1; j++)
    {
        Console.Write(ArrB[j]+", ");
    }
    Console.Write($"{ArrB[ArrB.Length-1]} ]");
}

// Программа
int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);
