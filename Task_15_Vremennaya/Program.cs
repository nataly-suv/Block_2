//  Програ принимает 3-х значное число и выводит 2-ую цифру 

Console.WriteLine("Введите трехзначное число");
string? inNumber = Console.ReadLine();

if (inNumber != null)
{
    int a = Convert.ToInt32(inNumber); //преобразование строки в int
    string b = a.ToString();   // преобразование int в строку
    char[] massiv = b.ToCharArray(); // преобразование строки в массив
    int count = massiv.Length;  // длина массива
    if (count != 3)  // проверка, что число 3-ч значное
    {
        Console.WriteLine("Вы ввели не трехзначное число. Запустите программу заново");
    }
    else
    {
        Console.WriteLine("Вторая цифра числа - " + massiv[1]);
    }
}

