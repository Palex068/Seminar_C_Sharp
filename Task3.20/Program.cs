/*Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и 
    находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.Write("Введите координату Х точки А: ");         // Приглашение к вводу числа    
double ax = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.Write("Введите координату Y точки А: ");         // Приглашение к вводу числа    
double ay = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.Write("Введите координату Z точки А: ");         // Приглашение к вводу числа    
double az = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.Write("Введите координату Х точки В: ");         // Приглашение к вводу числа    
double bx = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.Write("Введите координату Y точки В: ");         // Приглашение к вводу числа    
double by = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.Write("Введите координату Z точки В: ");         // Приглашение к вводу числа    
double bz = Convert.ToDouble(Console.ReadLine());           // Ввод числа

Console.WriteLine();

double result = Math.Round((Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2))),2);

// Для более читабельного кода вывел предварительный расчет

Console.WriteLine($"Расстояние между точками:{result}");    // Выводим результат