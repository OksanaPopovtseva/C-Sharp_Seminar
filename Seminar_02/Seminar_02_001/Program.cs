// Напишите программу, которая выводит целое случайное трехзначное число 
// и удаляет вторую цифру этого числа

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int a1 = number/100;
int a2 = number%10;
int a = a1*10+a2;
Console.WriteLine(a);
