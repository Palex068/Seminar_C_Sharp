/* Задача 55:
    Задайте двумерный массив.
    Напишите программу, которая заменяет строки на столбцы.
    В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] CreateMatrixTwoNumbers() // Создаем двумерный массив (Пользователь вводит размер) // С попыткой проверки ввода)))
{
    Console.Write($"Введите количество строк матрицы: "); 
    int arrayRow = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"Введите количество столбцов матрицы: "); 
    int arrayColumn = Convert.ToInt32(Console.ReadLine());

    while(arrayRow != arrayColumn)
    {
        Console.Write($"Вы ошиблись!\nКоличество строк и столбцов матрицы должны быть равны!\n"); 
        
        Console.Write($"Введите количество строк матрицы: "); 
        arrayRow = Convert.ToInt32(Console.ReadLine());
    
        Console.Write($"Введите количество столбцов матрицы: "); 
        arrayColumn = Convert.ToInt32(Console.ReadLine());   
    }

    int[,] matrix = new int[arrayRow,arrayColumn];
    return matrix;
    
}

void InputPrintMatrix(int[,] matrix, int minNumber = (1), int maxNumber = 11 ) // Заполняем матрицу и выводим
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

void Swap(ref int a, ref int b)                             // Замена
{
    int temp = a;
    a = b;
    b = temp;
}

void ChangeRowToColumnMatrix(int[,] matrix)                    // Заменяет строки на столбцы.
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j > i) Swap(ref matrix[i,j], ref matrix[j,i]);            
        }
        
    }
}

Console.Clear();

int [,] matrix = CreateMatrixTwoNumbers();

InputPrintMatrix(matrix);

ChangeRowToColumnMatrix(matrix);

PrintMatrix(matrix);
