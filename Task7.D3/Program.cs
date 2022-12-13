/*Доп задание
    Заполнение диагоналями
    Даны числа n и m.
    Создайте массив А[n,m] и заполните его, как показано на примере.

Входные данные
    4 10
Выходные данные
    0       1       3       6       10      14      18      22      26      30
    2       4       7       11      15      19      23      27      31      34
    5       8       12      16      20      24      28      32      35      37
    9       13      17      21      25      29      33      36      38      39
*/

int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер)
{
    Console.Write("Введите размер матрицы (два числа через пробел): ");
    int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
    return matrix;
}

void InputDiagonalMatrix(int[,] matrix)         // Заполняем матрицу
{
    int count = 0;
    
    for (int k = 0; k < matrix.GetLength(0) + matrix.GetLength(1); k++)
    {   
        for (int i = matrix.GetLength(1); i >= 0; i--)
        {
            int j = k - i;
            if(j >= 0 && i >=0 && j < matrix.GetLength(0) && i < matrix.GetLength(1))
            {
                matrix[j,i] = count;
                count++;
            }
        }        
    }
}

void PrintMatrix(int[,] matrix)         // Вывод матрицы
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");                                      
                
    Console.WriteLine();
    }
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputDiagonalMatrix(matrix);

PrintMatrix(matrix);