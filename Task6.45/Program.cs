/*Задача 45:
    Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/ 

// Разберем ввод в одну строку
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int arrayVolume = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrayVolume];

Console.Write($"Введите значения {arrayVolume} элементов массива (через пробел): ");


string[] numbers = Console.ReadLine().Split(" ");      // Создаем массив numbers из строки цифр через пробел

Console.WriteLine($"\n{string.Join($"\t", numbers)}");

for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(numbers[i]);

Console.WriteLine($"\n{string.Join($"\t", array)}");

int[] arrayCopy = new int[array.Length];

for (int i = 0; i < arrayCopy.Length; i++)
    arrayCopy[i] = array[i];
    
Console.WriteLine($"\n{string.Join($"\t", arrayCopy)}");

for (int i = 0; i < arrayCopy.Length; i++)
    arrayCopy[i] = arrayCopy[i] * arrayCopy[i];

Console.WriteLine($"\n{string.Join($"\t", array)}");
Console.WriteLine($"\n{string.Join($"\t", arrayCopy)}");
/*                                                        
foreach (string element in numbers)                    // foreach - цикл, который проходит по всем элементам массива
    Console.WriteLine(element);                        // и помещает по очереди их в переменную element
*/