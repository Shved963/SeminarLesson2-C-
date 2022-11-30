//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа.
//78-> 8
//12-> 2
//85-> 8

Console.Clear();

Random random = new Random();
int number = random.Next(10, 100);

int firstNumber = number/10;
int lastNumber = number%10;

if (firstNumber > lastNumber)
{
    Console.Write(number);
    Console.Write("-> ");
    Console.WriteLine(firstNumber);
}
else
{
    Console.Write(number);
    Console.Write("-> ");
    Console.WriteLine(lastNumber);
}
//Console.WriteLine(number);
//Console.WriteLine(firstNumber);
//Console.WriteLine(lastNumber);