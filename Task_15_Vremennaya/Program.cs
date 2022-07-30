// Вывести случайное число [10. 100] и показать наибольшую цифру числа

// вариант 1
void variant1(System.Random numberSint)
// в метод передаю переменную numberSint
{
    int number = numberSint.Next(10, 100);
    // вызываю метод Next для определя случайного числа [10, 100)
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    Console.WriteLine(number);

    if (firstNumber == secondNumber)
        Console.WriteLine("Цифры в числе одинаковые и равны - " + firstNumber);
    else if (firstNumber > secondNumber)
        Console.WriteLine("Максимальная цифра в цисле - " + firstNumber);
    else Console.WriteLine("Максимальная цифра в цисле - " + secondNumber);
    Console.WriteLine();
}

// вариант 2 
void variant2()
{
    int number2 = new Random().Next(10, 100);
    // более короткий способ определяни случайного числа
    Console.WriteLine("случайное число - " + number2);
    string stringNum = number2.ToString(); //перевожу число в строку

    if (stringNum[0] == stringNum[1])
        Console.WriteLine("Цифры равны и имеют значение " + stringNum[0]);
    else if (stringNum[0] > stringNum[1])
        Console.WriteLine("Максимальная цифра - " + stringNum[0]);
    else Console.WriteLine("Максимальная цифра - " + stringNum[1]);
    Console.WriteLine();
}

// вариант 3
void variant3()
{
    System.Random number3 = new Random();

    char[] mas = number3.Next(10, 100).ToString().ToCharArray();
    //          случайное чило переводим в строку и переводим в массив   

    Console.WriteLine(mas);

    int firstNum = ((int)mas[0]) - 48;
    int secondNum = ((int)mas[1]) - 48;

    // далее тернальный опрератор 
    int result = firstNum > secondNum ? result = firstNum : result = secondNum;
    Console.WriteLine("Максимальная цифра числа - " + result);
}

Console.Clear();
System.Random numberSint = new Random();  //определяю класс переменной numberSint

variant1(numberSint);
variant2();
variant3();
