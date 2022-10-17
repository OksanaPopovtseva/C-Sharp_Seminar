// 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99]

//Метод для создания рандомного массива
int[] CreateRandomArray()
{
    int[] array = new int[123];
    Random r = new Random();
    for (int i = 0; i < 123; i++)
    {
        array[i] = r.Next(1, 1000);
    }
    return array;
}

// Метод для подсчета количества элементов массива в отрезке [10,99]
int GetCalculatedCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

//Программа
int[] myArray = CreateRandomArray();
int result = GetCalculatedCount(myArray);
Console.WriteLine("Количество элементов в пределах [10,99] равно " + result);
