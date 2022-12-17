/*Задача 61:
    Вывести первые N строк треугольника Паскаля.
    Сделать вывод в виде равнобедренного треугольника
*/

int[,] CreatePascalMatrix() // Создаем двумерный массив (Пользователь вводит размер) // С проверкой на прямоугольность массива)))
{
    Console.Write($"Введите количество строк треугольника Паскаля: "); 
    int arrayRow = Convert.ToInt32(Console.ReadLine());
        
    int[,] matrix = new int[arrayRow,arrayRow];
    return matrix;    
}

void InputMatrix(int[,] matrix) // Заполняем матрицу и выводим её
{
    matrix[0,0] = 1;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < i +1; j++)
        {            
            if(j == 0 || matrix[i - 1,j] == 0)  matrix[i,j] = 1;
            
            else    matrix[i,j] = matrix[i - 1,j - 1] + matrix[i - 1,j];
        }        
    }
}

void PrintMatrix(int[,] matrix)                     // Вывод матрицы
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i,j] == 0)    Console.Write($" \t");
            
            else Console.Write($"{matrix[i,j]}\t");                                      
                
    Console.WriteLine();
    }
}

Console.Clear();

int [,] matrix = CreatePascalMatrix();

InputMatrix(matrix);

PrintMatrix(matrix);