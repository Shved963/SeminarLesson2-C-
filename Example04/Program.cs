//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

Console.Clear();

int num = int.Parse(Console.ReadLine());

int multiple1 = 7;
int multiple2 = 23;

if (num % multiple1 == 0 & num % multiple2 == 0)
{
    Console.WriteLine($"Число {num} кратно {multiple1} и {multiple2}");
}
else
{
    Console.WriteLine($"Число {num} НЕ КРАТНО {multiple1} и {multiple2}");
}