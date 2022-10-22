// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


//Программа
int N = GetValue("Введите число");
bool IsNValid = IsNumberValid(N);
if(IsNValid)
{
    if(N == 0) 
    {
        Console.WriteLine("[ 0 ]");
    }
    else 
    {
    int[] MyFibanacci = Fibonacci(N);
    PrintArray(MyFibanacci);
    }
}
else
{
    Console.WriteLine("Ошибка");
}


// Метод для считывания строки и перевода в int
int GetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

//Метод для проверки числа
bool IsNumberValid(int num)
{
    if (num >= 0)
        return true;
    return false;
}

// Метод Фибоначчи
int[] Fibonacci (int n)
{
    int[] FibArray = new int[n];
    FibArray[0] = 0;
    FibArray[1] = 1;
    for (int i = 2; i < FibArray.Length; i++)
    {
        FibArray[i]=FibArray[i-2]+FibArray[i-1];
    }
    return FibArray;
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