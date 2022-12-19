/*Задача 68:
    Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
   
*/


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int rec(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return rec(m - 1, 1);
    if (m > 0 && n > 0) return rec(m - 1, rec(m, n - 1));
    return rec(m,n);
}

Console.WriteLine($"A({m},{n}) = {rec(m, n)}");