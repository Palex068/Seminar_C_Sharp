/*Задача 51:
    Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.).

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер)
{
    Console.Write("Введите размер матрицы (два числа через пробел): ");
    int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
    return matrix;
}

void InputMatrix(int[,] matrix, int minNumber = (1), int maxNumber = 11 )         // Заполняем матрицу
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

string DiagonalSumInMatrix(int[,] matrix)         // Сумма элементов, находящихся на главной диагонали с указанием слагаемых
{
    Console.WriteLine();
    
    int diagonalSumInMatrix = matrix[0,0];        // Костыли для вывода слагаемых )))
    string result = $"{matrix[0,0]}";             // Аналогично)))
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {   
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if(i == j)
            {   
                diagonalSumInMatrix += matrix[i,j];
                result = result + " + " + matrix[i,j];
            }
        }        
    }
    return result + " = " + diagonalSumInMatrix;
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

Console.WriteLine($"Сумма элементов, находящихся на главной диагонали: {DiagonalSumInMatrix(matrix)}");