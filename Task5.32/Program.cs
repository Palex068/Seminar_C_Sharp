/* Задача 32:
    Напишите программу замена элементов массива:
    положительные элементы замените на соответствующие отрицательные, и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/ 

void InputArray(int[] array, int minNumber = (-9), int maxNumber = 9)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания мин -9 мах 9
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

void ChangeArray(int[] array)
{     
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *=(-1);
    }
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
int[] array = new int[n];
InputArray(array/*, minNumber, maxNumber*/);

// Console.WriteLine($"\n[{string.Join("\t", array)}]");

Console.WriteLine($"\nНачальный массив:\n[{string.Join("\t", array)}]");

ChangeArray(array);

Console.WriteLine($"\nИзменённый массив:\n[{string.Join("\t", array)}]");

