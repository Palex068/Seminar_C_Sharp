Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int I = N * (-1);
while (I <= N)
{
    Console.Write($"{I} ");
    I++; // I = I + 1, I+=1, (++1 - ?)
}
Console.WriteLine();