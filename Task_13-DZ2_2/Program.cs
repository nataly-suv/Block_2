// Вывести трьетью цифру числа, или сообщить, что третьей цифры нет
// баг - масимум можно ввести 9 цифр

int kolichestvo(int x) // Метод - определяю количество цифр в числе. 
{
    int count = 0;
    while (x > 0)
    {
        x = x / 10;
        count++;
    }
    Console.WriteLine($"В числе {count} цифр");
    return count;
}

Console.WriteLine("Введите число");
string? inNumber = Console.ReadLine();

if (inNumber != null)
{
    int number = int.Parse(inNumber);
    int count = kolichestvo(number); // вызываю метод
    if (count == 3)   // если в числе 3 цифры
    {
        int numberShort = number % 10;
        Console.WriteLine("Третья цифра - " + numberShort);
    }
    else if (count > 3)
    {
        double y = number / Math.Pow(10, (count - 3)); // отбрасываю хвост числа. оставляю 3 цифры
       double numberShort = Math.Floor(y); // округляю число до целого в меньшую сторону
       // int numberShort = (int)y;  // так тоже можно отбросить числа после запятой
        Console.WriteLine("Третья цифра - " + numberShort % 10);
    }
    else Console.WriteLine("В числе нет третьей цифры"); 

}
