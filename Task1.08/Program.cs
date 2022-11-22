Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int I = 2;I <= N; I+=2)
    Console.Write($"{I}\t");

Console.WriteLine();