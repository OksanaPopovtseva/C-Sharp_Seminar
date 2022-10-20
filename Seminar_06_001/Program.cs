//39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д)


// Программа
Console.Clear();
int ArrLenght = Prompt("Введите длину массива");
if (IsInputValid(ArrLenght))
{
    int[] myArray = CreateRandomArray(ArrLenght, 1, 10);
    Console.WriteLine("Массив: { " + String.Join(" | ", myArray) + " }");

    int[] revArray =CreateReverseArray(myArray);
    Console.WriteLine("Новый перевёрнутый массив: [ " + String.Join(" | ", revArray) + " ]");

    ReverseArray(myArray);
    Console.WriteLine("Массив перевернули: ( " + String.Join(" | ", myArray) + " )");
    Console.WriteLine("Перевернули обратно с помощью функции системы: { " + String.Join(" | ", myArray.Reverse()) + " }");
}
else
{
    Console.WriteLine("Неверная длина масива");

}

//Методы
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


bool IsInputValid(int N)
{
    if (N > 0) return true;
    return false;
}

int[] CreateRandomArray(int nArr, int min, int max)
{
    int[] array = new int[nArr];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] CreateReverseArray(int[] Arr)
{
    int[] newArr = new int[Arr.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = Arr[Arr.Length - 1 - i];
    }
    return newArr;
}

void ReverseArray(int[] Arr2)
{
    for (int i = 0; i < Arr2.Length / 2; i++)
    {
        int temp = Arr2[i];
        Arr2[i] = Arr2[Arr2.Length - 1 - i];
        Arr2[Arr2.Length - 1 - i] = temp;
    }
}