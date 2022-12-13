/*Задача 49:
    Задайте двумерный массив.
    Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
    
    Например, изначально массив             Новый массив будет выглядеть
    выглядел вот так:                       вот так:
    1 4 7 2                                 1 4 7 2
    5 9 2 3                                 5 81 2 9
    8 4 2 4                                 8 4 2 4
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
void ChangeMatrix(int[,] matrix, int minNumber = (-10), int maxNumber = 11 )         // Заполняем матрицу
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 1 && j % 2 == 1)
            {
                matrix[i,j] *= matrix[i,j];
            }
            else matrix[i,j] = 0;                                                   // обнулил остальные элементы, для наглядности)))

            Console.Write($"{matrix[i,j]}\t");                                      // и выводим её
        }        
    Console.WriteLine();
    }
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

ChangeMatrix(matrix);

