﻿/* Дополнительное задание - Статистика
    Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть,
    чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность:
        по нечетным дням месяца он получал тройки,
        по четным – четверки.
    Так же он помнит, в какие дни он получал эти оценки.
    Поэтому он выписал на бумажке все эти дни для того, чтобы оценить,
    сколько у него троек и сколько четверок. Помогите Васе это сделать,
        расположив четные и нечетные числа в разных строчках.
    Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

Входные данные:

Записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100).
Вторая строка содержит N чисел, представляющих заданный массив.
    Каждый элемент массива – натуральное число от 1 до 31.
Все элементы массива разделены пробелом.

Выходные данные
Нужно вывести числа, которые соответствуют дням месяцев,
в которые Вася получил тройки,                                              // выводим нечетные элементы массива
    во второй строке соответственно расположить числа месяца,
    в которые Вася получил четверки.                                        // выводим четные элементы массива
В третьей строке нужно вывести «YES»,
    если Вася может рассчитывать на четверку и «NO» в противном случае.     // если четных больше или равно нечетным выводим «YES»
В каждой строчке числа следует выводить в том же порядке,                   // если нечетных больше выводим «NO»
в котором они идут во входных данных. При выводе числа отделяются пробелом.
*/

void InputArray(int[] array, int minNumber = (1), int maxNumber = 32)       // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                           // по условию [1;31]
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber,maxNumber);
}


Console.Clear();

Console.Write("Введите количество оценок, которые получил Вася от 1 до 100 (включительно): ");

int number = Convert.ToInt32(Console.ReadLine());                                       // ВВод количества элементов массива

int[] array = new int[number];                                                          // Создаем массив вещественных чисел

while (number < 1 || number > 100)
{
    Console.Write("Вы ошиблись!\nВведите число от 1 до 100 (включительно): ");          // Проверим на соответствие условию
    number = Convert.ToInt32(Console.ReadLine());
}

InputArray(array);                                                                      // Заполняем массив

// Console.WriteLine($"\n[{string.Join("\t", array)}]");                                   // Вывод массива


int evenCount = 0, oddCount = 0;                                       // Объявим две переменные счетчики Четных и Нечетных чисел
string evenStr ="", oddStr = "";

for (int i = 0; i < array.Length; i++)                                 // Запустим первый for для Нечетных чисел
{
    if (array[i] % 2 == 1)                                             // Если элемент массива Нечетный
    {
        oddCount++;                                                    // Увеличиваем счетчик Нечетных чисел
        oddStr = oddStr + array[i].ToString() + " ";
    }
    if (array[i] % 2 == 0)                                             // Если элемент массива Четный
    {
        evenCount++;                                                   // Увеличиваем счетчик Четных чисел
        evenStr = evenStr + array[i].ToString() + " ";
    }
}

Console.Write($"\n Нечетные дни: {oddStr}");                                   // Перевод строки с комментарием
Console.Write($"\n Четные дни:   {evenStr}");                                   // Перевод строки с комментарием

if (evenCount >= oddCount)                                             // Если Четных дней больше или равно Нечетным дням
{
    Console.Write("\n \"YES\"");                                       // Говорим "YES"
}
else Console.Write("\n \"NO\"");                                       // Иначе говорим "NO"