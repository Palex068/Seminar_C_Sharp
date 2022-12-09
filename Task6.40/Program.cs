/*Задача 40:
    Напишите программу, которая 
    принимает на вход три числа и 
    проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.Write("Введите сторону А треугольника ABC: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону B треугольника ABC: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону C треугольника ABC: ");
int sideC = Convert.ToInt32(Console.ReadLine());

if (sideA + sideB > sideC)
    if (sideC + sideB > sideA)
        if(sideA + sideC > sideB)
            Console.WriteLine("Такой треугольник существует");

        else Console.WriteLine($"Такого треугольника не существует , т.к. A + C меньше либо равно B");

    else Console.WriteLine($"Такого треугольника не существует , т.к. C + B меньше либо равно A");
    
else Console.WriteLine($"Такого треугольника не существует , т.к. A + B меньше либо равно C");