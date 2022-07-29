// Задание и печать массива через методы (функции). Нахождение индекса элемента

// 1-ый метод (функция). Заполнение массива случайными значениями 

void FillArray(int[] collection)
/* задали метод void (не возвращает значение), 
имя метода FillArray, аргумент - массив с именем collection */
{
    int length = collection.Length; // орпеделили размер массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // заполнили массив случайными числами в диапазоне [1, 10)
        index++;
    }
}

// 2-ой метод (функция). Печатает массив

void PrintArray(int[] col)
/* задали метод void (не возвращает значение), 
имя метода PrintArray, аргумент - массив с именем col */
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}  ");
        // выводим на консоль элемент массива с индексом position в одну строчку
        position++;
    }
}

// 3-ий метод. Поиск позиции элемента
int IndexOf(int[] collection, int find) 
/* задали метод (функцию) с типом int, с именем IndexOf, 
с 2-мя агрументами: массив collection И переменная find */
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    /* задаем -1, чтобы при отсутствии элемента со значение find, 
    на консоль вывело -1, а не 0. Т.к. 0 это первый элемен массива */
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // чтобы выйти из цикла после первого вхождения
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; 
// создали новый массив с именем array с 10-ю элементами. по умолчанию они 0 

FillArray(array); //вызываем первый метод. рандомно заполняем массив
PrintArray(array); //вызываем второй метод. выводим массив на печать
Console.WriteLine(0); // Выводим пустую строку 
int answer = IndexOf(array, 4);   
// вызываем третий метод. В функции задаем массив array и значение к-ое ищем - 4
Console.WriteLine(answer);
Console.WriteLine();
