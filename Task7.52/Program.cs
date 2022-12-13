/*Задача 52.
    Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] ColumnsAverage(int[,] matrix)                              // Отдает массив с среднее арифметическим элементов каждого столбца
{
    double[] result = new double[matrix.GetLength(1)];              // Создадим массив для вывода ответа
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        double columnSum = 0;                                       // объявим сумму элементов столбца

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            columnSum += matrix[j,i];
        }
        result[i] = Math.Round(columnSum / matrix.GetLength(0), 2); // запишем среднее арифметическое в массив ответа
    }
    return result;                                                  // вернём массив с ответами
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

Console.WriteLine($"\nСреднее арифметическое элементов в каждом столбце: {string.Join("; ", ColumnsAverage(matrix))}.");