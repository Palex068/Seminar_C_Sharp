/*Задача 41:
    Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2

    1, -7, 567, 89, 223-> 3
*/
Console.Clear();

Console.Write("Введите количество чисел М: ");
int m = Convert.ToInt32(Console.ReadLine());

int countPositiveNumber = 0, number = 0;

string resultList = "";

for (int i = 1; i < m + 1; i++)
{
    Console.Write($"Введите {i} число: ");
    number = Convert.ToInt32(Console.ReadLine());
    
    if(i == 1)
        resultList += "[" + number.ToString() + ",";
    
    else if(i == m)
        resultList += " " + number.ToString() + "]";
    
    else resultList += " " + number.ToString() + ",";
    
    if(number > 0)
        countPositiveNumber++;    
}

Console.Write($"\n{resultList} -> {countPositiveNumber}");
