// Array
/*
Console.Clear();

Console.WriteLine();                                            

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < array.Length; i++)                          // Цикл заполнения цикла значениями через консоль
{
    Console.Write($"Введите значение {i + 1}-го элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"[{string.Join("\t", array)}]");      // Вывод массива без цикла
*/

Console.WriteLine();

void FillArray(int[] collection)  // создаем Метод заполнение массива псевдослучайными числами
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col) // создаем Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}\t");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
