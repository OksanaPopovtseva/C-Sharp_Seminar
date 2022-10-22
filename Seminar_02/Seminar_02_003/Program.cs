// Напишите программу, которая выводит случайное число от 10 до 99 
// и показывает наибольшую цифру числа.

int randomValue = new Random().Next(10,100);
int decadeDigit = randomValue/10;
int unitDigit = randomValue%10;
int maxValue = decadeDigit;

if(maxValue<unitDigit) maxValue = unitDigit;

Console.WriteLine(randomValue);
Console.WriteLine("Наибольшая цифра в числе = " + maxValue);
