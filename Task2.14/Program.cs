/* Задача 14
    Напишите программу, которая принимает
    на вход число и проверяет, кратно ли оно
    одновременно 7 и 23
    14 -> нет
    46 -> нет
    161 -> да
*/
Console.Clear();                                       // Очищаем терминал

Console.Write("Введите число: ");                      // Приглашение к вводу числа
int Number = Convert.ToInt32(Console.ReadLine());      // Ввод числа
  
System.Console.WriteLine();                            // Разделительная строка

if (Number % 7 == 0 && Number % 23 == 0)               // Если остаток деления на 7 и 23 равны 0

    System.Console.WriteLine($"{Number} -> да");       // Выводим: Число -> да
else
    System.Console.WriteLine($"{Number} -> нет");      // Иначе, выводим: Число -> нет

System.Console.WriteLine();                            // Разделительная строка
