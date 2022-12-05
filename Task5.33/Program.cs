/*Задача 33: 
    Задайте массив.
    Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет
    -3; массив [6, 7, 19, 345, 3] -> да*/

void InputArray(int[] array, int minNumber = (-9), int maxNumber = 9)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

string SearchInArray(int[] array, int k) 
{
    for (int i = 0; i < array.Length; i++)     
    {
    if (array[i] == k)
        return "-> да";
    }
    return "-> нет";
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);

//Console.WriteLine($"\n[{string.Join("\t", array)}]");

Console.Write("Введите число, которое нужно найти в массиве: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{number}; массив [{string.Join(", ", array)}] {SearchInArray(array, number)}");
