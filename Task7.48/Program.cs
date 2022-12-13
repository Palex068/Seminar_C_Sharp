/* Задача 48:
    Задайте двумерный массив размера m на n,
    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
    
    Выведите полученный массив на экран.

    m = 3, n = 4.

    0 1 2 3
    1 2 3 4
    2 3 4 5
*/

void InputMatrix(int[,] matrix)                         // Заполняем матрицу
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
            
            Console.Write($"{matrix[i,j]}\t");          // и выводим её
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