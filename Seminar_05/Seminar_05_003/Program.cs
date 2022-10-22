// 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Метод для создания строки, заданной пользователем
string GetString(int Num)
{
    string result = string.Empty;

    for (int i = 0; i < Num - 1; i++)
    {
        Console.WriteLine("Введите число");
        string value = Console.ReadLine();
        result = result + value + ",";
    }
    Console.WriteLine("Введите число");
    result = result + Console.ReadLine();
    return result;
}

//Метод для преобразования строки в массив
int[] ConvertToArray(string numbers)
{
    string[] ArrayA = numbers.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] ArrA = new int[ArrayA.Length];
    for (int i = 0; i < ArrayA.Length; i++)
    {
        ArrA[i] = int.Parse(ArrayA[i]);
    }
    return ArrA;
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

//Метод для поиска числа в массиве
bool IsArrayHaveNumber(int[] nums, int aNum)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == aNum)
            return true;
    }
    return false;
}


//Программа
int N = GetNumber("Введите длину массива");
if(N>0)
{
string newArray = GetString(N);
int A = GetNumber("Введите искомое число");

int[] Arr = ConvertToArray(newArray);

Console.WriteLine();
Console.Write($"Введенная строка: {newArray}");
Console.WriteLine();
Console.Write("Массив чисел: ");
PrintArray(Arr);
Console.WriteLine();

bool IsNum = IsArrayHaveNumber(Arr, A);
if (IsNum)
{
    Console.WriteLine($"Число {A} есть в массиве");
}
else
{
    Console.WriteLine($"Числа {A} нет в массиве");
}
}
else
{
    Console.WriteLine("Неверные данные");
}