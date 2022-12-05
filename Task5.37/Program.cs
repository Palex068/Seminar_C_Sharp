/*Задача 37:
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
// Вариант 1
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}
// Метод 1 - Преподавателя

void ReleaseArray1(int[] array)                  // IMHO: в этом решении есть ошибка, в массиве с нечётным количеством элементов
{                                                // средний не должен возводиться в квадрат, а тут множится на себя
    int[] resultArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        resultArray[i] = array[i] * array[array.Length - i - 1];
    
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
}
// Метод 2 - Преподавателя
void ReleaseArray2(int[] array)                  // В этом решении то же самое)))
{     
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.Write($"[{array[i] * array[array.Length - i - 1]}]");       // Тут не исправишь, т.к. произведения выводятся сразу)))
}

int[] ReleaseArray1A(int[] array)                  // Поправлю сначала тут
{                                                  // 
    int[] resultArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        resultArray[i] = array[i] * array[array.Length - i - 1];
    if (array.Length % 2 == 1)                                              // Если Начальный массив имеет нечетное количество элементов
        resultArray[resultArray.Length-1] = array[resultArray.Length-1];    // то меняем его квадрат само значение
    return resultArray;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);

// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int[] newArray = ReleaseArray1A(array); // Новый массив из метода

Console.WriteLine($"\n[{string.Join(" ", array)}] -> {string.Join(" ", newArray)}"); // Формат вывода как в условии)

// ReleaseArray2(array);
