﻿// Поиск позиции элемента массисва

// индексы      0   1   2   3  4   5   6   7   8
int[] array = { 12, 44, 73, 4, 11, 56, 87, 5, 14 };
// задали массив с типом int и именем array
int n = array.Length;
int find = 4;
// будеи искать индекс элемента массива, значение которого равно 4. 
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        /* прерывает цикл после первого вхождения. 
        Иначе выведет все индексы элементов, значнеи которых равно 4 */
    }
    index++;
}
if (index == 9 && array[8] != find)
    Console.WriteLine("нет значений, удовлетворяющих условию");