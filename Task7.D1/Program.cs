/* Доп задание
Транспонирование - 4

Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

Входные данные
    два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные
    выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
3 4
5 9 2 6                 1 2 8 7
6 2 4 3                 6 2 4 3
1 2 8 7                 5 9 2 6
*/

int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер)
{
    Console.Write("Введите размер матрицы (два числа через пробел): ");
    int[] arrayVolume = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
    return matrix;
}

void InputMatrix(int[,] matrix, int minNumber = (-100), int maxNumber = 101 )         // Заполняем матрицу
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


int[,] TranspMatrix(int[,] matrix)                                    // Отдает массив с Транспонирование по горизонтали
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];              // Создадим массив для вывода ответа
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[j,i] = matrix[matrix.GetLength(0) - j - 1,i];
        }
    }
    return result;                                                  // вернём массив с ответами
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

int [,] result = TranspMatrix(matrix);

PrintMatrix(result);