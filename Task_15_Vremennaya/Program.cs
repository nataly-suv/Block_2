// использум функции
int a1 = 230, b1 = 2, c1 = 56;
int a2 = 87, b2 = 1200, c2 = 980;
int a3 = 123,  b3 = 77712, c3 = 578921;

int Max(int arg1, int arg2, int arg3)  // задаем функцию Max с 3-мя агрументами
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                       // возвращаем значение функции 
}
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));  // Внутри аргумента передаем функцию

Console.WriteLine(max);