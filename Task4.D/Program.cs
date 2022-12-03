/* Дополнительное задание:
    Суперсдвиг

    Дана последовательность из N целых чисел и число K.
    Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
    если K – положительное и влево, если отрицательное.

    N (натуральное число) -количество элементов массива (1 ≤ N ≤ 105),
    Массив: N целых чисел Ai (|Ai| ≤ 100),
    K - целое число, на которое происходит сдвиг значений массива (|K| ≤ 105).
*/ 
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(new Random().Next(1,101));
}

Console.WriteLine($"\n[{string.Join("\t", array)}]");

Console.Write("\nВведите значение для сдвига элементов массива: ");
int k = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(k) > n) k = k % n;                                         // Если сдвиг длиннее массива, то сдвигаем на остаток от деления

if(k < 0)
{ 
    Array.Reverse(array,0, -k);                              //
    Array.Reverse(array, -k, array.Length + k);              // Сдвиг массива влево <- на к элементов
    Array.Reverse(array, 0, array.Length);                   //
}
else
{ 
    Array.Reverse(array,0, array.Length - k);                //
    Array.Reverse(array, array.Length -k, k);                // Сдвиг массива вправо - > на к элементов
    Array.Reverse(array, 0, array.Length);                   //
}

Console.WriteLine($"\n[{string.Join("\t", array)}]");
