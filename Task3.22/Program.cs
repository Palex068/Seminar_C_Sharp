/*Задача 22
    Напишите программу, которая принимает на вход число (N)
    и выдаёт таблицу квадратов чисел от 1 до N.
    5 -> 1, 4, 9, 16, 25.
    2 -> 1,4
*/

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int I = 1;I <= N; I+=1)
    Console.Write($"{Math.Pow(I, 2)}\t");

Console.WriteLine();