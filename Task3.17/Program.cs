/*Задача17
    Напишите программу, которая принимает на вход координаты точки (X и Y),
    причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
    2|1
    3|4
*/
Console.Clear();

Console.WriteLine("Введите координату Х:");         // Приглашение к вводу числа    

double x = Convert.ToDouble(Console.ReadLine());    // Ввод числа

Console.WriteLine("Введите координату Y:");         // Приглашение к вводу числа    

double y = Convert.ToDouble(Console.ReadLine());    // Ввод числа

if (x > 0 && y > 0)                                 
    System.Console.WriteLine("I");

else if (x < 0 && y > 0)                       
    System.Console.WriteLine("II");

else if (x < 0 && y < 0)                       
    System.Console.WriteLine("III");

else 
    System.Console.WriteLine("IV");



