/*Задача 35:
    Задайте одномерный массив из 123 случайных чисел.
    Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
    Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
    [5, 18, 123, 6, 2] -> 1
    [1, 2, 3, 6, 2] -> 0
    [10, 11, 12, 13, 14] -> 5
*/

void InputArray(int[] array, int minNumber = (-200), int maxNumber = 200)       // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                               // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

int CountArrayElements(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)     
    {      
    if (array[i] >= 10 && array[i] < 100)
        count ++;
    }
    return count;
}
Console.Clear();
Console.WriteLine();

int[] array = new int[123];
InputArray(array);
Console.WriteLine($"одномерный массив из 123 случайных чисел:\n[{string.Join("\t", array)}] -> {CountArrayElements(array)}");
