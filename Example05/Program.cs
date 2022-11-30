//4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

Console.Clear();

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

int resultA = numA % numB;
int resultB = numB % numA;

//Console.WriteLine(resultA);
if (resultA == 0 & numB*numB == numA)
{
    Console.WriteLine("Да");
}
else
if (resultB == 0 & numA*numA ==numB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
