/*Задача 39:
    Напишите программу, которая перевернёт одномерный массив
    (последний элемент будет на первом месте, а первый - на последнем и т.д.)
    
    [1 2 3 4 5] -> [5 4 3 2 1]
    [6 7 3 6] -> [6 3 7 6]
*/



/* // Решение преподавателя:
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReverseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
*/

void InputArray(int[] array, int minNumber = (1), int maxNumber = 11)         // Метод заполнения массива, передаем  массив, мин и макс значения
{                                                                             // В этой задаче есть умолчания
    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minNumber, maxNumber +1); 
}

int[] ReversArray(int[] array)
{
    int [] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length / 2 + 1; i++)
    {
        resultArray[i] = array[array.Length - 1 -i];
        resultArray[array.Length - 1 - i] = array[i];
    }
    return resultArray;
}

Console.Clear();

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

InputArray(array);

int[] resultArray = ReversArray(array);

Console.WriteLine($"\n[{string.Join(" ", array)}] -> [{string.Join(" ", resultArray)}]"); 