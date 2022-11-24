﻿/* Задача 10:
    Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/
Console.Clear();                                                    // Очистим терминал

Console.Write("Введите трехзначное число: ");                       // Приглашение к вводу трехзначного числа

int N = Convert.ToInt32(Console.ReadLine());                        // Ввод числа

while (N < 100 || N > 999)                                          // Проверим число, что оно трехзначное
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число: ");     // Сообщение об ошибке
    N = Convert.ToInt32(Console.ReadLine());                        // Новый ввод числа
}

int N3 = N / 100;                                                   // Вычисляем количество сотен
int N2 = (N - N3*100) / 10;                                         // Вычисляем количество десятков
int N1 = N - N2 * 10 - N3 * 100;                                    // Вычисляем количество единиц

// Необязательные действия, но красивые))
System.Console.WriteLine();                                         // Разделительная строка        

System.Console.WriteLine($"Количество сотен:    {N3}");             // Выводим на экран количество десятков
System.Console.WriteLine($"Количество десятков: {N2}");             // Выводим на экран количество десятков
System.Console.WriteLine($"Количество десятков: {N1}");             // Выводим на экран количество единиц

System.Console.WriteLine();                                         // Разделительная строка        

Console.WriteLine($"{N} -> {N2}");                                  // Вывод решения по аналогии с примером

System.Console.WriteLine();                                         // Разделительная строка        

// Короткое решение

Console.Write($"{N} -> {N / 10 - (N / 100)*10}");                   // Решение в одну строку

System.Console.WriteLine();                                         // Разделительная строка        
