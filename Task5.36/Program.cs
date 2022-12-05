/*Задача 36:
    Задайте одномерный массив, заполненный случайными числами.
    Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/
void InputArray(int[] array, int minNumber = (-20), int maxNumber = 20)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

int SumUnevenArrayElements(int[] array)             // Сумма элементов массива, стоящих на нечётных позициях
{
    int sumUnevenArrayElements = 0;
    for (int i = 1; i < array.Length; i+=2)     
    {      
        sumUnevenArrayElements +=array[i];
    }
    return sumUnevenArrayElements;
}
Console.Clear();

Console.Write("Введите кол-во элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

Console.WriteLine($"\n[{string.Join(", ", array)}] -> {SumUnevenArrayElements(array)}");
