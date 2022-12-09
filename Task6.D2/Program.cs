/* Доп задание Площадь треугольника
По целочисленным координатам вершин треугольника
(x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Входные данные:
    6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника.
    Все числа не превышают 106 по абсолютной величине.

Выходные данные:
    выведите точное значение площади заданного треугольника.

    2 1 2 4 6 1 -> 6

    0 0 0 3 3 0 -> 4.5
*/

Console.Clear();

Console.Write("Введите координату Х Точки А: ");           // Приглашение к вводу числа    

double ax = Convert.ToDouble(Console.ReadLine());          // Ввод числа

Console.Write("Введите координату Y Точки А: ");           // Приглашение к вводу числа    

double ay = Convert.ToDouble(Console.ReadLine());          // Ввод числа

Console.Write("Введите координату Х Точки В: ");           // Приглашение к вводу числа    

double bx = Convert.ToDouble(Console.ReadLine());          // Ввод числа

Console.Write("Введите координату Y Точки B: ");           // Приглашение к вводу числа    

double by = Convert.ToDouble(Console.ReadLine());          // Ввод числа

Console.Write("Введите координату Х Точки C: ");           // Приглашение к вводу числа    

double cx = Convert.ToDouble(Console.ReadLine());          // Ввод числа

Console.Write("Введите координату Y Точки C: ");           // Приглашение к вводу числа    

double cy = Convert.ToDouble(Console.ReadLine());          // Ввод числа

double a = Math.Round((Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow((ay - by), 2))),3);    // Сторона AB
double b = Math.Round((Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow((by - cy), 2))),3);    // Сторона BC
double c = Math.Round((Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow((ay - cy), 2))),3);    // Сторона AC

double p = (a + b + c) / 2;                                                 // Находим p - полу периметр

double S = Math.Round((Math.Sqrt(p * (p - a) * (p - b) * (p - c))),3);      // S треугольника по формуле Герона

Console.WriteLine($"\nA ({ax};{ay}) B ({bx};{by}) C ({cx};{cy})");

Console.WriteLine($"\nДлинна AB: {a}\nДлинна BС: {b}\nДлинна AС: {c}");

Console.WriteLine($"\nПлощадь треугольника: {S}");                          // Результат
