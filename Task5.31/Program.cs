/*Задача 31:
    Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
    Найдите сумму отрицательных и положительных элементов массива.
    Например,
    в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

*/ 
void InputArray(int[] array, int minNumber = (-9), int maxNumber = 9)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

void ReleaseArray(int[] array)
{     
    int sumNegative = 0, sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sumPositive += array[i];
        else
        sumNegative += array[i];
    }
    Console.WriteLine($"\nСумма положительных чисел равна: {sumPositive}");
    Console.WriteLine($"\nСумма отрицательных чисел равна: {sumNegative}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
/*
Console.Write("Введите минимальное значение элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
*/
int[] array = new int[n]; InputArray(array/*, minNumber, maxNumber*/);

Console.WriteLine($"\n[{string.Join("\t", array)}]");
ReleaseArray(array);