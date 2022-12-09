/*Задача 42:
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    45 -> 101101
    3  -> 11
    2  -> 10
*/ 
Console.Clear();

Console.Write("Введите число n: ");

int number = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
int n = number;

while (n > 0)                                   // Вычисление ответа через остаток от деления на основание системы исчисления
{
    result = Convert.ToString(n % 2) + result;  // К полученному остатку приписываем предыдущие остатки
    n /= 2;                                     // Само деление
}

Console.WriteLine(number + " -> " + result + " - Решение через вычисления" );

Console.WriteLine($"{number} -> {Convert.ToString(number, 2)} - Решение через оператор \"Convert.ToString(n, 2)\"");
