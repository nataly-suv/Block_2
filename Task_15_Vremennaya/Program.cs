// использум функции
int a1 = 230;
int b1 = 2;
int c1 = 56;
int a2 = 87;
int b2 = 1200;
int c2 = 980;
int a3 = 123;
int b3 = 77712;
int c3 = 578921;

int Max(int arg1, int arg2, int arg3)  // задаем функцию Max с 3-мя агрументами
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                       // возвращаем значение функции 
}
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
