// 31: Задайте массив из 12 элементов, наполненный случайными числами
// из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива. 

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


//
int[] input = CreateRandomArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0)
    {
        positiveSum += input[i];
    }
    else
    {
        negativeSum += input[i];
    }
}

string inputString = string.Join(",", input);
Console.WriteLine("Массив = {" + inputString + "} Сумма положительных элементов = "
                + positiveSum + " Сумма отрицательных элементов = " + negativeSum);