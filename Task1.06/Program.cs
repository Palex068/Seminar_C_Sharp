/* Задача 6:
    Напишите программу, которая на вход принимает число и выдаёт,
    является ли число чётным (делится ли оно на два без остатка).
*/
Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
    Console.WriteLine($"{N} чётное число");
else
    Console.Write($"{N} нечётное число");
Console.WriteLine();