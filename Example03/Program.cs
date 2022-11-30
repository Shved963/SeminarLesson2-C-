//2.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 16, 4 -> кратно


Console.Clear();
Console.WriteLine("Введите два числа");

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int lastNum;

if (numA % numB == 0)
{
    Console.Write(numA);
    Console.Write(", ");
    Console.Write(numB);
    Console.Write(" = кратно");
}
else
{
    lastNum = numA % numB;

    Console.Write(numA);
    Console.Write(", ");
    Console.Write(numB);
    Console.Write(" = не кратно, остаток ");
    Console.Write(lastNum);
}
