/*Дополнительная задача 1
    Гипотеза Гольдбаха
    Известно, что любое чётное число, большее 2,
    представимо в виде суммы 2 простых чисел,
    причём таких разложений может быть несколько.
    
    Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

    Требуется написать программу, производящую согласно утверждению Гольдбаха,
    разложение заданного чётного числа. 
    Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару,
    содержащую наименьшее простое число.

    Ввод:
        чётное число N (4 ≤ N ≤ 998).

    Выводные данные:
        Два простых числа, сумма которых равна числу N.
        Первым выводится наименьшее число.
        6 -> 3 3
        992 -> 73 919
Алгоритм решения:
    1. Создаем метод создания массива простых чисел от 2 до введенного числа
            1.1 Создадим массив логических значений
            1.2 Заполним массив значениями true начиная с 2(индекс) элемента
                2 - это первое простое число
            1.3 Применим на массиве Алгоритм Решето Эратосфена https://ru.wikipedia.org/wiki/Решето_Эратосфена

    2. Объявим метод по поиску числа в массиве
    3. Запросим ввод числа
    4. Будем вычитать из введённого числа элементы массива
       с простыми числами по порядку возрастания и искать остаток в этом же массиве
    5. В случае нахождения остатка в массиве простых чисел получим ответ

Алгоритмы для изучения https://habr.com/ru/post/526924/
*/ 


Console.Clear();

bool [] PrimeBoolArrayMethod(int numberForCheckGBSum)                           // Метод создания логического ряда простых чисел от 2 до
{                                                                         // введённого числа
    
    bool[] primeBoolArray = new bool[numberForCheckGBSum];                // Создаем логический массив))) 

    for (int i = 2; i < primeBoolArray.Length; i++)                       // Заполним массив значениями true
    {
        primeBoolArray[i] = true;
    }

    for (int p = 2; p * p < primeBoolArray.Length; p++)                   // Применим Алгоритм Решето Эратосфена
    {
        if (primeBoolArray[p])                                            // Если элемент массива p = true, т.е. мы его ещё не исключили
        {
            for (int i = p * p; i < primeBoolArray.Length; i += p)        // Начиная от i равного p в квадрате с шагом p 
            {
                primeBoolArray[i] = false;                                // Исключим числа кратные p
            }
        }
    }
    return primeBoolArray;
}

// Console.WriteLine($"\n[{string.Join("\t", primeBoolArray)}]");     // Вывод массива
/*
for (int prime = 0; prime < primeBoolArray.Length; prime++)           // Вывод в консоль ряда простых чисел   
{
    if(primeBoolArray[prime])
        Console.Write($"{prime}\t");
}
*/

void GoldbachsTest(int number)                                        // Метод нахождения пары чисел Гольдбаха с мин первым значением
{
    bool [] primeBoolArray = PrimeBoolArrayMethod(number);

    for (int summandGBA = 0; summandGBA < number; summandGBA++)
    {
        if (primeBoolArray[summandGBA])
        {
            if(primeBoolArray[number-summandGBA])
            {
                Console.WriteLine($"\n{number} -> {summandGBA} + {number-summandGBA}");
                break;
            }
        }                                            
    }
}

Console.Write("Введите четное число от 4 до 998: ");
int number = Convert.ToInt32(Console.ReadLine());                     // Ввод числа

while (number < 4 || number > 998 || number % 2 ==1)
{
    Console.Write("Вы ошиблись!\nВведите четное число от 4 до 998: ");// Проверим на соответствие условию
    number = Convert.ToInt32(Console.ReadLine());
}
GoldbachsTest(number);

/* Решение преподавателя
void Main()
{         
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }
        if (countDel == 0)
        {
            countDel = 0;
            m = n - i;
            for (k = 2; k <= (m + 1) / 2; k++)
            {
                if (m % k == 0)
                    countDel++;
            }
            if (countDel == 0)
            {
                Console.WriteLine($"{i} {m}");
                return;
            }
        }
    }
}
*/