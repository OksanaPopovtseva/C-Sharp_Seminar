// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int GetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int a = GetValue("Введите номер четверти");

switch (a)
{
    case 1:
        Console.WriteLine("Диапазон координат точек: x>0, y>0");
        break;
    case 2:
        Console.WriteLine("Диапазон координат точек: x<0, y>0");
        break;
    case 3:
        Console.WriteLine("Диапазон координат точек: x<0, y<0");
        break;
    case 4:
        Console.WriteLine("Диапазон координат точек: x>0, y<0");
        break;
    default:
        Console.WriteLine("Ошибка");
        break;
}