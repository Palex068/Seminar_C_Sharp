/* Задача 3
    Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
    5 -> Пятница
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