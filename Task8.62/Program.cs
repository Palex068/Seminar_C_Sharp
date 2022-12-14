/*Задача 62.
    Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/
int[,] CreateMatrix() // Создаем квадратный массив
{
    Console.Write($"Введите количество строк квадратного массива: "); 
    int arrayRow = Convert.ToInt32(Console.ReadLine());
        
    int[,] matrix = new int[arrayRow,arrayRow];
    return matrix;    
}

void InputMatrix(int[,] matrix)                                                     // Заполняем спирально квадратную матрицу 
{
    int elementsCount = 1, flag = 0, length = matrix.GetLength(0);                  // объявляем flag (направление) и length (для компактности кода)

    int limiterLeft = 0, limiterRight = 0, limiterUp = 0, limiterDown = 0;          // добавляем ограничители
    
    while(limiterDown + limiterUp < length || limiterRight + limiterLeft < length)  // пока ограничители в сумме меньше размера матрицы
    {
        if(flag == 0)       // идём вправо
            for(int i =  limiterLeft; i < length - limiterRight; i++)
            {
                matrix[limiterUp,i] = elementsCount;
                elementsCount ++;
            }
            flag = 1;
            limiterUp ++;
            
        if(flag == 1)       // идем вниз
        {
            for(int i =  limiterUp; i < length - limiterDown; i++)
            {
                matrix[i,length - limiterRight-1] = elementsCount;
                elementsCount ++;
            }
            flag = 2;
            limiterRight++;

        }
        if(flag == 2)       // идём влево
        {
            for(int i =  length - limiterRight-1; i >= limiterLeft; i--)
            {
                matrix[length - limiterDown-1, i] = elementsCount;
                elementsCount ++;
            }
            flag = 3;
            limiterDown++;
        }
        if(flag == 3)       // идем вверх
        {
            for(int i =  length - limiterDown - 1; i >= limiterUp ; i--)
            {
                matrix[i, limiterLeft] = elementsCount;
                elementsCount ++;
            }
            flag = 0;
            limiterLeft++;

        }
    }
    return;
}

void PrintMatrix(int[,] matrix)                     // Вывод матрицы
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");                                      
                
    Console.WriteLine();
    }
}

/*
// Решение преподавателя

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}
PrintArray(array);
*/
void ReversInputMatrix(int [,] matrix)          // Переделал для разбора часть решения преподавателя в обратное заполнение
{
    int num = matrix.GetLength(0)*matrix.GetLength(1) - 1;
    int i = 0;
    int j = 0;

    while (num >= 0)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < matrix.GetLength(1)  - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(0) - 1)
            j--;
        else
            i--;
        num--;
    }
}
// PrintArray(array);


Console.Clear();

int [,] matrix = CreateMatrix();

InputMatrix(matrix);

PrintMatrix(matrix);

ReversInputMatrix(matrix);

PrintMatrix(matrix);
