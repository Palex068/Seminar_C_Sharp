/* Задача 2:
    Напишите программу, которая на вход принимает два числа и
    выдаёт, какое число большее, а какое меньшее.
*/

Console.Clear();

Console.Write("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

 // Решение через цикл

if (number2 > number1)
    Console.WriteLine($"Максимальное число равно: {number2}\nМинимальное число равно: {number1}");
else
    Console.WriteLine($"Максимальное число равно: {number1}\nМинимальное число равно: {number2}");
 
/* //Решение с помощью метода

int NumbersMax(int n, int m)                            // Объявили Метод
{
    if (n > m)                                          // Цикл Если - сравнение
        return n;
    return m;
}
Console.WriteLine(NumbersMax (number1, number2));       // Вывод
*/
Console.WriteLine();