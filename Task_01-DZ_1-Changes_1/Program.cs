// Поиск максимального из 2-х. Тернарная операция.
Console.WriteLine("Введите первое число");
string? inNumber1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inNumber2 = Console.ReadLine();
if (inNumber1 != null && inNumber2 != null)
{
    int number1 = int.Parse(inNumber1);
    int number2 = int.Parse(inNumber2);
    int result = number1 > number2 ? number1 : number2; // тернальный оператор. 
    // если условие (number1>number2) true (выполняется), то в result записываем number1, 
    // если условие не выполняется, то в result записывает number2. 
    Console.Write($"Максимальное число - {result}");
}

