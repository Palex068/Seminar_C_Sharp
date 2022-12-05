/*Задача 34:
    Задайте массив заполненный случайными положительными трёхзначными числами.
    Напишите программу, которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2
*/ 

void InputArray(int[] array, int minNumber = (100), int maxNumber = 999)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

int CountEvenNumbersInArray(int[] array)                     // Подсчет чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)     
    {
    if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите кол-во элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

//Console.WriteLine($"\n[{string.Join("\t", array)}]");

Console.WriteLine($"\n[{string.Join(", ", array)}] -> {CountEvenNumbersInArray(array)}");

