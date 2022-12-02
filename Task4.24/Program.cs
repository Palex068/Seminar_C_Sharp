/* Задача 24:
    Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    7 -> 28
    4 -> 10
    8 -> 36
*/
Console.Clear();

Console.Write("Введите число: ");                                 // Приглашение для ввода числа А
int number = Convert.ToInt32(Console.ReadLine());                 // Объявили переменную, вводим и конвертируем в Int32

Console.WriteLine();                                              // Строка разделитель
int result = 0;                                                   // Объявили переменную - ответ

for (int i = 1; i < number + 1; i++)                              // Цикл for от 1 до А с шагом 1
{
    result +=i;                                                   // Увеличиваем result на i
}

Console.WriteLine($"Решение с использованием цикла:\nСумма чисел от 1 до {number} = {result}");    // Выводим результат

double nDouble = Convert.ToDouble(number);                        // Сконвертируем number в nDouble

// Применим формулу суммы n членов прогрессии и выведем результат:

double resultDouble = (1 + nDouble) / 2 * nDouble;
Console.WriteLine($"Решение с использованием формулы\nСумма чисел от 1 до {nDouble} = {resultDouble}");