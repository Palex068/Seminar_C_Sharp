/*Задача 56:
    Задайте прямоугольный двумерный массив.
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] CreateMatrixTwoNumbers() // Создаем двумерный массив (Пользователь вводит размер) // С проверкой на прямоугольность массива)))
{
    Console.Write($"Введите количество строк матрицы: "); 
    int arrayRow = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"Введите количество столбцов матрицы: "); 
    int arrayColumn = Convert.ToInt32(Console.ReadLine());

    while(arrayRow == arrayColumn)
    {
        Console.Write($"Вы ошиблись!\nКоличество строк и столбцов матрицы не должно быть равно!\n"); 
        
        Console.Write($"Введите количество строк матрицы: "); 
        arrayRow = Convert.ToInt32(Console.ReadLine());
    
        Console.Write($"Введите количество столбцов матрицы: "); 
        arrayColumn = Convert.ToInt32(Console.ReadLine());   
    }

    int[,] matrix = new int[arrayRow,arrayColumn];
    return matrix;
    
}

void InputPrintMatrix(int[,] matrix, int minNumber = (1), int maxNumber = 11 ) // Заполняем матрицу и выводим её с суммой элементов строки
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int rowSum = 0;       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            matrix[i,j] = new Random().Next(minNumber, maxNumber);
            rowSum += matrix[i,j];
            Console.Write($"{matrix[i,j]}\t");                                      
        }        
    Console.WriteLine($"Row {i+1} Sum: {rowSum}");
    }
}

int ArrayMinPosition(int[] array)                   // Поиск позиции мин значения в одномерном массиве
{
    int arrayMinPosition = 0;
    
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < array[arrayMinPosition]) arrayMinPosition = i;
    }
    return arrayMinPosition;
}

int FindRowMinSumMatrix(int[,] matrix)                    //  выдаёт номер строки с наименьшей суммой элементов
{    
    int[] rowSumArray = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            rowSumArray[i] += matrix[i,j];
        }       
    }
    return ArrayMinPosition(rowSumArray);    
}

Console.Clear();

int [,] matrix = CreateMatrixTwoNumbers();

InputPrintMatrix(matrix);

Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {FindRowMinSumMatrix(matrix) + 1}-я строка");

// Если суммы нескольких строк равны и минимальны, то программа выдаст первую из них, в условии задачи нет об этом указаний))) 