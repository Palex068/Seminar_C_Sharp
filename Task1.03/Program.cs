/* Задача 3
    Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
    a = 25, b = 5 -> да 
    a = 2, b = 10 -> нет 
    a = 9, b = -3 -> да 
    a = -3 b = 9 -> нет
*/

Console.Clear();

Console.Write("Введите порядковый номер дня недели: ");
int numberDayOnWeek = Convert.ToInt32(Console.ReadLine());

while (numberDayOnWeek < 1 || numberDayOnWeek > 7)
{
    Console.Write("Вы ошиблись!\nВведите порядковый номер дня недели: ");
    numberDayOnWeek = Convert.ToInt32(Console.ReadLine());
}    
if(numberDayOnWeek == 1)
    Console.Write("Этот день недели: Понедельник");
else if(numberDayOnWeek == 2)
    Console.Write("Этот день недели: Вторник");
else if(numberDayOnWeek == 3)
    Console.Write("Этот день недели: Среда");
else if(numberDayOnWeek == 4)
    Console.Write("Этот день недели: Четверг");
else if(numberDayOnWeek == 5)
    Console.Write("Этот день недели: Пятница");
else if(numberDayOnWeek == 6)
    Console.Write("Этот день недели: Суббота");
else
    Console.Write("Этот день недели: Воскресенье"); 
Console.WriteLine();