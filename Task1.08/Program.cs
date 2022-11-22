// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int I = 2;I <= N; I+=2)
    Console.Write($"{I}\t");

Console.WriteLine();