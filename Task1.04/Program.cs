Console.Clear();

Console.Write("Введите 1-е число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int Max = Number1;

if (Number2 > Max)
    Max = Number2;
    if(Number3 > Max)
        Max = Number3;
Console.WriteLine($"Максимальное число равно: {Max}");

Console.WriteLine();