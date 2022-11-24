/* Задача 11
    Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    456 -> 46
    782 -> 72
    918 -> 98
*/

Console.Clear();

int randomNumber = Convert.ToInt32(new Random().Next(100, 1000));   // Генерируем случайное число от 100 до 999

System.Console.WriteLine($"Случайное число: {randomNumber}");       // Выводим на экран сгенерированное число

System.Console.WriteLine();                                         // Разделительная строка

int N3 = randomNumber / 100;                                        // Вычисляем количество сотен
int N2 = (randomNumber - N3*100) / 10;                              // Вычисляем количество десятков
int N1 = randomNumber - N2 * 10 - N3 * 100;                         // Вычисляем количество единиц

// Необязательные действия, но красивые))

System.Console.WriteLine($"Количество сотен:    {N3}");             // Выводим на экран количество десятков
System.Console.WriteLine($"Количество десятков: {N2}");             // Выводим на экран количество десятков
System.Console.WriteLine($"Количество десятков: {N1}");             // Выводим на экран количество единиц


System.Console.WriteLine();                                         // Разделительная строка

// Продолжение обязательного кода

int Number = N3 * 10 + N1;                                          // Собираем число - ответ

System.Console.WriteLine($"{randomNumber} -> {Number}");            // Выводим ответ на печать

System.Console.WriteLine();                                         // Разделительная строка

System.Console.WriteLine("Второе решение");                                                         // Второе решение

System.Console.WriteLine();                                                                         // Разделительная строка

System.Console.WriteLine($"{randomNumber} -> {(randomNumber / 100) * 10 + randomNumber % 10}");     // Собираем ответ