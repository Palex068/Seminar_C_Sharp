/* Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и
    находит расстояние между ними в 2D пространстве.
    A (3,6); B (2,1) -> 5,09 
    A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();

Console.WriteLine("Введите координату Х Точки А:");         // Приглашение к вводу числа    

double ax = Convert.ToDouble(Console.ReadLine());    // Ввод числа

Console.WriteLine("Введите координату Y Точки А:");         // Приглашение к вводу числа    

double ay = Convert.ToDouble(Console.ReadLine());    // Ввод числа

Console.WriteLine("Введите координату Х Точки В:");         // Приглашение к вводу числа    

double bx = Convert.ToDouble(Console.ReadLine());    // Ввод числа

Console.WriteLine("Введите координату Y Точки В:");         // Приглашение к вводу числа    

double by = Convert.ToDouble(Console.ReadLine());    // Ввод числа

Console.WriteLine($"Расстояние между точками:{Math.Round((Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow((ay-by), 2))),3)}"); // Math.Pow((az-bz), 2) для пространства