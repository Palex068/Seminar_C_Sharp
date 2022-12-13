/*Задача 46:
    Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    
    m = 3, n = 4.
    
    1   4   8   19
    5   -2  33  -2
    77  3   8   1
*/

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
    Console.WriteLine($"\n");
    }
}

Console.Clear();

Console.Write("Введите размер матрицы (два числа через пробел): ");
string[] arrayVolume = Console.ReadLine().Split(" ");

int row = int.Parse(arrayVolume[0]);
int column = int.Parse(arrayVolume[1]);

int[,] matrix = new int[row,column];

InputMatrix(matrix);