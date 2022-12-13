/*Задача 47.
    
    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.

    0,5 7 -2 -0,2

    1 -3,3 8 -9,9

    8 7,8 -7,1 9

*/

void InputMatrix(double[,] matrix, int minNumber = (-10), int maxNumber = 10 )        // Заполняем матрицу
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * new Random().Next(minNumber, maxNumber + 1), 2);
            
            Console.Write($"{matrix[i,j]}\t");                                        // и выводим её
        }        
    Console.WriteLine($"\n");
    }
}

Console.Clear();

Console.Write("Введите размер матрицы (два числа через пробел): ");
string[] arrayVolume = Console.ReadLine().Split(" ");

int row = int.Parse(arrayVolume[0]);
int column = int.Parse(arrayVolume[1]);

double[,] matrix = new double[row,column];

InputMatrix(matrix);