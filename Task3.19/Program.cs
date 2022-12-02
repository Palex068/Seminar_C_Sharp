﻿/* Задача 19:
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    23432 -> да
    12821 -> да
*/
Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 10000 || N > 99999) // Проверим число, что оно трехзначное
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}    
int N1 = N / 10000;                                             // 
int N2 = N / 1000 - N1 * 10;                                    //
int N3 = N / 100 - N2 * 10 - N1 * 100;                          //  Разберём число по цифрам
int N4 = N / 10 - N3 * 10 - N2 * 100 - N1 * 1000;               //
int N5 = N - N4 * 10 - N3 * 100 - N2 * 1000 - N1 * 10000;       //

// Console.WriteLine($"{N1}, {N2}, {N3}, {N4}, {N5}");          // Это был проверочный вывод)

if (N1 == N5 && N2 == N4)
    Console.WriteLine($"{N} -> да");
else
    Console.WriteLine($"{N} -> нет");