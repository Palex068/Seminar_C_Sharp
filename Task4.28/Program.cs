/*Задача 28:
    Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    4 -> 24 
    5 -> 120
*/

Console.Clear();                                    // Очистили консоль

Console.Write("Введите число: ");                   // Приглашение к вводу числа

int number = Convert.ToInt32(Console.ReadLine());   // Ввод

int NumberFactorial(int number)                   // Объявили Метод
{
    int result = 1;                                 // Объявили переменную result = 0
    
    for (int i = 1; i < number + 1; i++)
    {
        result *=i;
    }
    return result;                                  // Возвращаем n!
}

Console.WriteLine();
Console.WriteLine($"{number}! = {NumberFactorial(number)}");  // Применим Метод на числе и выведем результат