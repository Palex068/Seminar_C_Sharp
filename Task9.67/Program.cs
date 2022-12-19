/*Задача 67:
    Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
    453 -> 12
    45 -> 9
*/
Console.Clear();                                    // Очистили консоль

Console.Write("Введите число: ");                   // Приглашение к вводу числа

int number = Convert.ToInt32(Console.ReadLine());   // Ввод

int DigitsSumOfNumber(int number)                   // Объявили Метод
{
    int result = 0;                                 // Объявили переменную result = 0
    while (number != 0)                             // Цикл Пока number не равен 0
    {
        result +=number % 10;                       // Складываем в result остаток деления на 10 (последнюю цифру)
        number/=10;                                 // Делим number на 10 (есть подозрение, что можно записать иначе, но я пока такого не знаю)
    }
    return result;                                  // Возвращаем сумму цифр числа, т.к. мы его доделили до нуля
}

Console.WriteLine($"Сумма знаков в числе {number} = {DigitsSumOfNumber(number)}");  // Применим Метод на числе и выведем результат

int rec(int a)
{
    if (a / 10 == 0 || a < 10 || a % 10 == a)
        return a;
    return rec(a / 10) * (a % 10);
}

Console.WriteLine($"Рекурсия: Произведение знаков в числе {number} = {rec(number)}");
