// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// Метод для ввода и принятия координат
int GetValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = Convert.ToInt32(value);
    return a;
}

// Метод для расчета расстояния
double Distance(int x1, int x2, int y1, int y2)
{
    double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    S = Math.Round(S,2);
    return S;
}

// Программа
int xA = GetValue("Введите координату x для точки A");
int yA = GetValue("Введите координату y для точки A");
int xB = GetValue("Введите координату x для точки B");
int yB = GetValue("Введите координату y для точки B");

Console.WriteLine("Расстояние между точками: " + Distance(xA, xB, yA, yB));