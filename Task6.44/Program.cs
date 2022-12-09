/* Задача 44: 
    Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

Console.Write("Введите кол-во чисел Фибоначчи: ");

int volume = Convert.ToInt32(Console.ReadLine());

int[] fibonacciList = new int[volume];

for (int i = 2; i < volume; i++)
{
    fibonacciList[0] = 0;
    fibonacciList[1] = 1;
    fibonacciList[i] = fibonacciList[i -1] + fibonacciList[i - 2]; 
}
Console.WriteLine($"{string.Join(" ", fibonacciList)}");
/*
//Решение преподавателя

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x; 
}
*/