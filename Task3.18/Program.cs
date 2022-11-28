/*Задача 18
    Напишите программу, которая по заданному номеру четверти,
    показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.Clear();

Console.WriteLine("Введите номер четверти:\n2 | 1\n-----\n3 | 4");          // Приглашение к вводу числа    
int N = Convert.ToInt32(Console.ReadLine());                                // Ввод числа

if (N == 1)                                 
    System.Console.WriteLine("X > 0; Y > 0");
        
else if (N == 2)                       
    System.Console.WriteLine("X < 0; Y > 0");

else if (N == 3)                       
    System.Console.WriteLine("X < 0; Y < 0");

else 
    System.Console.WriteLine("X > 0; Y < 0");
