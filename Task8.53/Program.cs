/*Задача 53:
    Задайте двумерный массив. 
    Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
int[,] CreateMatrix() // Создаем двумерный массив (Пользователь вводит размер) // С попыткой проверки ввода)))
{
    Console.Write("Введите размер матрицы (два числа через пробел): "); 
    //TODO: Дописать проверку на ввод чисел а не текстовых символов
    string input = Console.ReadLine();
    
    int countOfSpace = 0;      
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ') 
            countOfSpace ++;
    }
    
    while (input.Length == 0 ||                 // ничего не введено
            countOfSpace !=1 ||                 // пробелов больше одного
            input[0] == ' '  ||                 // пробел на 0 месте
            input[input.Length-1] == ' ')       // пробел на последнем месте            
    {
        Console.Write($"Вы ошиблись!\nВведите размер матрицы (два числа через пробел): ");
        input = Console.ReadLine();        
        countOfSpace = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ') 
                countOfSpace ++;
        }
    }
    int[] arrayVolume = input.Split(" ").Select(s => int.Parse(s)).ToArray();  // Исключили добавление переменных
    int[,] matrix = new int[arrayVolume[0],arrayVolume[1]];
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

void ChangeMatrix(int[,] matrix)                    // Поменяет местами первую и последнюю строку массива.
{
    int temp;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {   
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1,j];
        matrix[matrix.GetLength(0) - 1,j] = temp;
    }
}

Console.Clear();

int [,] matrix = CreateMatrix();

InputPrintMatrix(matrix);

ChangeMatrix(matrix);

PrintMatrix(matrix);
