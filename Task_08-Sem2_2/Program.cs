// Удаление 2-ой цифры в 3-х значном числе

void variant1()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("исходное число: " + number);

    int num1 = number / 100;
    int num3 = number % 10;
    int result = num1 * 10 + num3;
    Console.WriteLine("ответ: " + result);
}

void variant2()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("исходное число: " + number);
    string numString = number.ToString();
    Console.Write("ответ:  ");
    Console.Write(numString[0]);
    Console.Write(numString[2]);
}

variant1();
Console.WriteLine();
variant2();

