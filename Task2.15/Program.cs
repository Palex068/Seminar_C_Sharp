/*Задача 15
    Напишите программу, которая принимает на вход цифру, обозначающую
    день недели, и проверяет, является ли этот день выходным
    6 -> да 
    7 -> да 
    1 -> нет
*/
Console.Clear();

Console.Write("Введите порядковый номер дня недели: ");                     // Приглашение к вводу числа
int numberDayOnWeek = Convert.ToInt32(Console.ReadLine());                  // Ввод числа

System.Console.WriteLine();                                                 // Разделительная строка        


while (numberDayOnWeek < 1 || numberDayOnWeek > 7) {                        //
    Console.Write("Вы ошиблись!\nВведите порядковый номер дня недели: ");   // Проверка на диапазон от 1 до 7
    numberDayOnWeek = Convert.ToInt32(Console.ReadLine());                  //
    }    

if (numberDayOnWeek == 6 || numberDayOnWeek == 7)                           // Если число 6 или 7
   
    Console.Write($"{numberDayOnWeek} -> да");                              // Выводим Число -> да
else                                                                        // Иначе
    Console.Write($"{numberDayOnWeek} -> нет");                             // Выводим Число -> нет

System.Console.WriteLine();                                                 // Разделительная строка        
