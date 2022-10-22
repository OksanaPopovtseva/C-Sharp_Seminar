// 32: Напишите программу замены элементов массива:
// положительные элементы заменить на соответствующие отрицательные,
// и наоборот.

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

//Метод для замены элементов
void ChangeElements (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=array[i]*-1;
    }
}

//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
    Console.Write("}");
}

//Программа
int N = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимум для элементов");
int max = GetNumber("Введите максимум для элементов");

int[] myArray = CreateRandomArray(N,min,max);
PrintArray(myArray);
ChangeElements(myArray);
Console.WriteLine();
PrintArray(myArray);