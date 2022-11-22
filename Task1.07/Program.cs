Console.Clear();

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 100 || N > 999) // Проверим число, что оно трехзначное
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}    
Console.Write($"Последняя цифра: {N % 10}");

Console.WriteLine();
