/*Задача 43:
    Напишите программу, которая найдёт точку пересечения двух прямых,
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    значения b1, k1, b2 и k2 задаются пользователем.

    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    // Если k1 == k2, точки пересечения нет т.к. прямые параллельны. 
*/

Console.Clear();

double k1, k2, b1, b2, x, y;

Console.Write("Введите k1: ");
k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

if(k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
else Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Прямые не пересекаются, они - параллельны");