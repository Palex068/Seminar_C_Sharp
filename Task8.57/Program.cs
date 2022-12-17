/*Задача 57:
    Составить частотный словарь элементов двумерного массива.
    Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

void InputPrintMatrix(int[,] matrix, int minNumber = (0), int maxNumber = 6 ) // Заполняем матрицу и выводим
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

List<int> ElementsList(int[,] matrix)                                           // Список элементов массива
{
    List<int> elementsList = new List<int>(matrix.GetLength(0) * matrix.GetLength(1));
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(!elementsList.Contains(matrix[i,j]))
                elementsList.Add(matrix[i,j]);                                      
    }
    return elementsList;
}

void Swap(ref int a, ref int b)                             // Замена
{
    int temp = a;
    a = b;
    b = temp;
}

void SortElementsDictionary(int[,] matrix)                    // Упорядочит по убыванию элементы массива
{    
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        int numberMaxColumn = k;
        
        for (int j = k+1; j < matrix.GetLength(0); j++)
        {   
            if(matrix[j,1] > matrix[numberMaxColumn,1])
            numberMaxColumn = j;
        }
        Swap(ref matrix[k,0], ref matrix[numberMaxColumn,0]);
        Swap(ref matrix[k,1], ref matrix[numberMaxColumn,1]);               
    }     
}

int[,] ElementsDictionaryFromMatrix(int[,] matrix)                              // Частотный словарь
{
    List<int> elementsList = ElementsList(matrix);

    int[,] elementsDictionary = new int[elementsList.Count, 2];

    for (int k = 0; k < elementsDictionary.GetLength(0); k++)
    {
        elementsDictionary[k, 0] = elementsList[k];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i,j] == elementsDictionary[k, 0])
                    count ++;
            }
        }
        elementsDictionary[k, 1] = count;
    }
    SortElementsDictionary(elementsDictionary);
    return elementsDictionary;
}


void PrintElementsDictionaryFromMatrix(int[,] matrix)                     // Вывод матрицы
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(j == 0)
                Console.Write($"Цифра: {matrix[i,j]}");
            else Console.Write($" ==> {matrix[i,j]} шт.\n");
    }
}
Console.Clear();

int [,] matrix = CreateMatrix();

InputPrintMatrix(matrix);

int [,] elementsDictionary = ElementsDictionaryFromMatrix(matrix);

PrintElementsDictionaryFromMatrix(elementsDictionary);
