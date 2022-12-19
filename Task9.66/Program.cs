/*Задача 66:
    Задайте значения M и N.
    Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int[] InputTwoNumbersInLine() // Создаем массив из двух чисел (Пользователь вводит через пробел) // С попыткой проверки ввода)))
{
    Console.Write("Введите два числа M и N (через пробел): "); 
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
        Console.Write($"Вы ошиблись!\nВведите два числа M и N (через пробел): ");
        input = Console.ReadLine();        
        countOfSpace = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ') 
                countOfSpace ++;
        }
    }
    int[] numbers = input.Split(" ").Select(s => int.Parse(s)).ToArray();
    return numbers;
}

int rec(int m, int n)
{
    if (m == n)
        return m;
    return rec(m, n - 1) + n;
}

int ElementsSumFromMToN(int m, int n)
{
    int result = 0;
    for (int i = m; i <= n; i++) result+=i;
    return result;
}

Console.Clear();                                                

int[] numbers = InputTwoNumbersInLine();

Console.Write($"\nЦикл: Сумма натуральных элементов в промежутке от {numbers[0]} до {numbers[1]}");
Console.Write($" = {ElementsSumFromMToN(numbers[0], numbers[1])}\n");
Console.Write($"\nРекурсия: Сумма натуральных элементов в промежутке от {numbers[0]} до {numbers[1]}");
Console.Write($" = {rec(numbers[0], numbers[1])}\n");

// Тут больше украшательств, чем самого кода!
// Хотелось продлить практику программирования)))