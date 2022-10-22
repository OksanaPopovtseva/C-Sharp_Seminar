// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Метод для считывания введеных пользователем данных
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Метод по созданию массива координат для точки
int[] ReadPoint()
{
    int xIndex = 0;
    int yIndex = 1;
    int zIndex = 2;
    int[] point = new int[3];
    point[xIndex] = Prompt("Введите X");
    point[yIndex] = Prompt("Введите Y");
    point[zIndex] = Prompt("Введите Z");
    return point;
}

// Метод для нахождения суммы квадратов
double SumSquare(int[] pointA, int[] pointB)
{
    double sum = 0;
    for (int i = 0; i < pointA.Length; i++)
    {
        sum += Math.Pow(pointA[i] + pointB[i], 2);
    }

    Console.WriteLine($"Sum = {sum}");

    return sum;
}

// Метод для вычисления расстояния
double CalcDistance(int[] pointA, int[] pointB)
{
    double distance = Math.Sqrt(SumSquare(pointA, pointB));
    distance = Math.Round(distance,2);
    return distance;
}

// Программа
int[] A = ReadPoint();
int[] B = ReadPoint();
double distanceAB = CalcDistance(A, B);
Console.WriteLine($"Расстояние между точками равно = {distanceAB}");
