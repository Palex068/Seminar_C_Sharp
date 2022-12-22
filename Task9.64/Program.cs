/*Задача 64: Вариант из другой группы
    Задайте значение N.
    Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1.
    
    N = 5 -> "2, 4"
    N = 8 -> "2, 4, 6, 8"
*/
string rec(int n)
{
    if (n == 2)
        return "2 ";
    return rec(n - 2) + $"{n} ";
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2  == 1)
{
    n = n - 1;
    Console.WriteLine(rec(n));
}
else Console.WriteLine(rec(n));