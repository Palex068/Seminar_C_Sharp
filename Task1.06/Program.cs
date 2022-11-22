Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
    Console.WriteLine($"{N} кратно 2");
else
    Console.Write($"{N} не кратно 2");
Console.WriteLine();