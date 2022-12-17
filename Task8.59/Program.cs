/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер)
{
    Console.Write("Введите размер матрицы (два числа через пробел): ");
    int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
    return matrix;
}

void InputMatrix(int[,] matrix, int minNumber = (0), int maxNumber = 11 )         // Заполняем матрицу
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

int[] CoordMinNumberSearch(int[,] matrix)                              // Отдает массив с мин значением массива и его положение
{
    int[] coordMinNumber = new int[3];
    int minNumber = matrix[0,0], minNumberI = 0, minNumberJ = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if(matrix[i,j] < matrix[minNumberI,minNumberJ])
            {
                minNumber = matrix[i,j];
                minNumberI = i;
                minNumberJ = j;
            }
        }
    }
    coordMinNumber[0] = minNumber;
    coordMinNumber[1] = minNumberI;
    coordMinNumber[2] = minNumberJ;

    return coordMinNumber;
}

void PrintResult(int[,] matrix, int[] result)           // Выводит массив без строки и столбца, на пересечении которых расположен 
                                                        // наименьший элемент массива.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i != result[1] && j != result[2])
            {
                Console.Write($"{matrix[i,j]}\t");
            }
        }
        Console.WriteLine();
    }
}
Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

int[] result = CoordMinNumberSearch(matrix);
Console.WriteLine($"\nМинимальное значение матрицы: {result[0]} ({result[1]}, {result[2]}).");

PrintResult(matrix, result);

// Можно объединить поиск и вывод в одну процедуру, но я подумал, что поиск наименьшего (наибольшего значения пригодится)