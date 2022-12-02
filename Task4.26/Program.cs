/* Задача 26:
    Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    456 -> 3
    78 -> 2
    89126 -> 5
*/ 


Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Решение через Метод

int NumberOfDigits(int number)
{
    int result = 0;
        while (number != 0)
    {
        number /=10;
        result ++;
    }
    return result;
}
Console.WriteLine($"Число {number} - {NumberOfDigits(number)} значное");

/*
// Решение через цикл while

int result = 0;
int numberCopy = number;
while (numberCopy != 0)
{
    numberCopy /=10;
    result ++;
}

Console.WriteLine();

Console.WriteLine($"Число {number} - {result} значное");
*/

/*
Console.Clear();

void NumberPlus10(ref int a)                            // Объявили Процедуру, которая меняет отправленную переменную
{
    a = a + 10;
}

Console.Write("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
NumberPlus10(ref n);                                    // ref нужно указывать при обращении к единичной переменной
                                                        // для массива нет необходимости
Console.WriteLine(n);                                   // Вывод
*/
Console.WriteLine();
