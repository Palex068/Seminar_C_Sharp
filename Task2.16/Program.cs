/* Задача 16.
    Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
    5,  25  ->  да
    -4, 16  ->  да
    25, 5   ->  да
    8,  9   ->  нет
*/
Console.Clear();                                                      // Очищаем терминал
Console.Write("Введите 1-е число: ");                                 // Приглашение к вводу первого числа
int Number1 = Convert.ToInt32(Console.ReadLine());                    // Ввод первого числа
  
Console.Write("Введите 2-е число: ");                                 // Приглашение к вводу первого числа
int Number2 = Convert.ToInt32(Console.ReadLine());                    // Ввод второго числа

System.Console.WriteLine();                                           // Разделительная строка

if (Number1 == Number2 * Number2 || Number2 == Number1 * Number1)     // Условие: Если N1 = N2^2 или N2 = N1^2
    
    Console.Write($"{Number1}, {Number2} -> Да");                     // Тогда выводим Да

else
    
    Console.Write($"{Number1}, {Number2} -> Нет");                    // Тогда выводим Нет

System.Console.WriteLine();