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
if(numberDayOnWeek == 2)
    Console.Write("Этот день недели: Вторник");
if(numberDayOnWeek == 3)
    Console.Write("Этот день недели: Среда");
if(numberDayOnWeek == 4)
    Console.Write("Этот день недели: Четверг");
if(numberDayOnWeek == 5)
    Console.Write("Этот день недели: Пятница");
if(numberDayOnWeek == 6)
    Console.Write("Этот день недели: Суббота");
if(numberDayOnWeek == 7)
    Console.Write("Этот день недели: Воскресенье"); 
