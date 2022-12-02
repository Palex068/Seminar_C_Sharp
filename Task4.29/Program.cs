/*Задача 29:
    Напишите программу, которая задаёт массив из 8 элементов, .

    1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/ 

Console.Clear();

int[] array = new int[8];

// заполним массив через чикл for

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение {i + 1}-го элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

// Выводим элементы массива через строку без цикла

Console.WriteLine($"\n[{string.Join(", ", array)}]");

Console.WriteLine("\nРешение с использованием методов:\n");

void FillArray(int[] array)  // создаем Метод заполнение массива через консоль
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"Введите значение {index + 1}-го элемента массива: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] array ) // создаем Метод печати массива
{
    int length = array.Length;
    int index = 1;
    
    Console.Write($"\n[{array[0]}");
    while (index < length)
    {
        Console.Write($", {array[index]}");
        index++;
    }
    Console.Write("]\n");
}

FillArray(array);
PrintArray(array);
