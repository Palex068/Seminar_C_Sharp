/*
Задача 7
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает последнюю цифру этого числа.
    456 -> 6
    782 -> 2
    918 -> 8
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 100 || N > 999) // Проверим число, что оно трехзначное
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}    
Console.Write($"Последняя цифра: {N % 10}");

Console.WriteLine();
