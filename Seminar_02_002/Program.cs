// Напишите программу, которая выводит целое случайное трехзначное число 
// и удаляет вторую цифру этого числа. Решение через строку

int number = new Random().Next(100,1000);
Console.WriteLine(number);

string A = number.ToString();
Console.Write(A[0]);
Console.Write(A[2]);