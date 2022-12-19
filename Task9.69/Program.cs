/*Задача 69:
    Напишите программу, которая на вход 
    принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
*/

int rec(int a, int b)           // Рекурсия
{
    if (b == 0 && a != 0)
        return 1;
    return rec(a, b - 1) * a;
}

Console.Clear();                                                

Console.Write("Введите число А: ");                             
int numberA = Convert.ToInt32(Console.ReadLine());              

Console.Write("Введите число B: ");                             
int numberB = Convert.ToInt32(Console.ReadLine());              

Console.WriteLine();                                            // Строка разделитель

int result = 1;                                                 // Объявим переменную result

for (int i = 0; i < numberB; i++)                               // Цикл for от 0 до числа В с шагом 1
{
    result *=numberA;                                           // Множим result на число А
}
Console.WriteLine($"{numberA} в {numberB} степени = {result}"); // Выводим результат 



Console.WriteLine($"\nРекурсия: {numberA} в {numberB} степени = {rec(numberA, numberB)}");