// Массив. Поиск максимального в массиве с помощью метода (функции)

// создаем метод (функцию) для поиска max из трех
int Max(int arg1, int arg2, int arg3)                  
{        // тело метода (функции)  
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индексы      0   1  2    3   4   5   6   7   8
int[] array = { 1001, 54, 66, 43, 89, 27, 123, 3, 63 };   
// создали массив с типом int, c именем array

int max = Max(                       // вызываем метод (функцию)
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine($"Максимальный элемент массива -  {max}");