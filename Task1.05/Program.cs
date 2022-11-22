Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int I = N * (-1);I <= N; I++)
    Console.Write($"{I}\t");
   
Console.WriteLine();