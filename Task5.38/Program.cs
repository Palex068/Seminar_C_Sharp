/*Задача 38:
    Задайте массив вещественных чисел.
    Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76


*/ 

/* Проба пера)))
double MinSearch(double[] array)                                                // Метод поиска минимального значения
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minNumber > array[i])
            minNumber = array[i];
        
    }
    return minNumber;
}
*/
/* Проба пера
double MaxSearch(double[] array)                                                // Метод поиска максимального значения
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
            maxNumber = array[i];
        
    }
    return maxNumber;
}
*/
/* Игрался с выводом двух решений из одного метода

double[] MinMaxSearch(double[] array)                                                // Метод поиска минимального и максимального значения одновременно)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
            maxNumber = array[i];
        if (minNumber > array[i])
            minNumber = array[i];
    }
    double[] MinMaxArray = new double[2] {minNumber, maxNumber};
    return MinMaxArray;
}
*/
/* Выводы промежуточных решений

Console.WriteLine($"\n Минимальное значение: {MinSearch(array)}");

Console.WriteLine($"\n Максимальное значение: {MaxSearch(array)}");

Console.WriteLine($"\n Минимальное значение: {MinMaxSearch(array)[0]}");
Console.WriteLine($"\n Максимальное значение: {MinMaxSearch(array)[1]}");
Console.WriteLine($"\n Разница между максимальным и минимальным значениями:\n {MinMaxSearch(array)[1] - MinMaxSearch(array)[0]}");
*/
/*
Console.WriteLine($"\n Разница между максимальным и минимальным значениями:\n {MinMaxSubtraction(array)}");
*/


void InputArray(double[] array, int minNumber = (-100), int maxNumber = 100)    // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                               // будем NextDouble множить на Next
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * new Random().Next(minNumber,maxNumber);
}

double MaxMinSubtraction(double[] array)                                                // Метод поиска разности  максимального и минимального значения
{
    double minNumber = array[0];
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minNumber > array[i])
            minNumber = array[i];
        if (maxNumber < array[i])
            maxNumber = array[i];
    }
    return maxNumber - minNumber;
}

Console.Clear();

Console.Write("Введите кол-во элементов массива вещественных чисел: ");

int n = Convert.ToInt32(Console.ReadLine());                                        // ВВод количества элементов массива
double[] array = new double[n];                                                     // Создаем массив вещественных чисел

InputArray(array);                                                                  // Заполняем массив

Console.WriteLine($"\n[{string.Join("\t", array)}] -> {MaxMinSubtraction(array)}"); // Вывод ответа по форме задания

