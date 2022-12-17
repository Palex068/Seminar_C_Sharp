/*Задача 58:
Задайте две матрицы.
Напишите программу, которая будет находить произведение элементов двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
6 16
9 6
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

int[,] ProductMatrix(int[,] matrixOne,int[,] matrixTwo)                    //Массив элементов равных произведению соответствующих элементов двух матриц
{
    int[,] productMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {   
            productMatrix[i,j] = matrixOne[i,j] * matrixTwo[i,j];
        }
    }
    return productMatrix;
}

Console.Clear();

int [,] matrixOne = CreateMatrix();

System.Console.WriteLine($"\nМассив 1:");
InputPrintMatrix(matrixOne);

int [,] matrixTwo = new int[matrixOne.GetLength(0),matrixOne.GetLength(1)];

System.Console.WriteLine($"\nМассив 2:");
InputPrintMatrix(matrixTwo);

int[,] productMatrix = ProductMatrix(matrixOne, matrixTwo);

System.Console.WriteLine($"\nМассив с произведением элементов массивов 1 и 2:");
PrintMatrix(productMatrix);