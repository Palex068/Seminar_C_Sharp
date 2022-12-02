/*Задача 25:
    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    НЕ ИСПОЛЬЗОВАТЬ Math.Pow 
    // Задача предусматривает, что А и В натуральные числа (особенно А)?

    3, 5 -> 243 (3⁵)

    2, 4 -> 16
*/ 
Console.Clear();                                                // Очистим консоль

Console.Write("Введите число А: ");                             // Приглашение к вводу числа А
int numberA = Convert.ToInt32(Console.ReadLine());              // Ввод

Console.Write("Введите число B: ");                             // Приглашение к вводу числа В
int numberB = Convert.ToInt32(Console.ReadLine());              // Ввод

Console.WriteLine();                                            // Строка разделитель

int result = 1;                                                 // Объявим переменную result

for (int i = 0; i < numberB; i++)                               // Цикл for от 0 до числа В с шагом 1
{
    result *=numberA;                                           // Множим result на число А
}
Console.WriteLine($"{numberA} в {numberB} степени = {result}"); // Выводим результат 

Console.WriteLine();                                            // Строка разделитель
