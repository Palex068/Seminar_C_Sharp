// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите 1-е число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
    Console.WriteLine($"Максимальное число равно: {Number2}\nМинимальное число равно: {Number1}");
else
    Console.WriteLine($"Максимальное число равно: {Number1}\nМинимальное число равно: {Number2}");
    
Console.WriteLine();