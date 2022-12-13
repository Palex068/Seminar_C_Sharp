/*Задача 50.
    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции в массиве нет
*/

int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер)
{
    Console.Write("Введите размер матрицы (два числа через пробел): ");
    int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
    return matrix;
}

void InputMatrix(int[,] matrix, int minNumber = (-10), int maxNumber = 11 )         // Заполняем матрицу
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i,j] = new Random().Next(minNumber, maxNumber);
            Console.Write($"{matrix[i,j]}\t");                                      // и выводим её
        }        
    Console.WriteLine();
    }
}

void SearchInMatrix(int[,] matrix, int row, int column)         // Элемент массива по данным позиции
{
    Console.WriteLine();
    if(row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
    {
        Console.WriteLine($"{row} {column} -> такой позиции в массиве нет");
        return;
    }
    else
        Console.WriteLine($"{row} {column} -> {matrix[row,column]}");
        return;
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

Console.Write($"\nВведите позицию элемента (два числа через пробел): ");

int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();

SearchInMatrix(matrix, arrayVolume[0], arrayVolume[1]);