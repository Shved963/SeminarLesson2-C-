//1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46 782 -> 72 918 -> 98

Console.Clear();

Random random = new Random();
int number = random.Next(100, 1000);

int firstNumber = number / 100;
int lastNumber = number % 10;
Console.Write(number);
Console.Write("-> ");
Console.Write(firstNumber);
Console.Write(lastNumber);
