Console.Clear();
// Console.WriteLine("Hello, World!");

Console.Write("Введите число: ");
// Способ ввода данных 1
int number1 = int.Parse(Console.ReadLine());

// Console.Write("Введённое число больше 10? ");
// Console.Write(Convert.ToInt32(number1 > 10));
// Console.Write("Введите второе число: ");
// Способ ввода данных 2
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введённые числа не равны? ");
// Console.Write((number1 != number2));
// Console.WriteLine(number1 * 2);
// Console.WriteLine(number2 * 3);

// Console.Write("Первое число больше чем второе? ");
// Console.WriteLine(number1 > number2);

// Напишите программу, которая принимает на вход число и
// проверяет кратно ли оно одновременно 2 и 3, если ктарно,
// то вывести Yes, инначе вывести No

// Коньюнкция (логическое умножение) && матеиатическая запись ^
// Дизъюнкция (логическое сложение) || матеиатическая запись v

// Чтобы закоментировать выбранную область нужно нажать ctrl + /

Console.WriteLine();
Console.Write("Кратно ли введённое число одновременно 2 и 3 ? ");
if(number1 % 2 == 0 && number1 % 3 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
