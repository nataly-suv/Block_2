// Поиск максимального из трех с помощью Math класса.
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int resultMiddle = Math.Max(number1, number2);
int result = Math.Max(number3, resultMiddle);

//int result = Math.Max(number1, Math.Max(number2, number3)); 
// это подсмотрено. но себе сохраню, как клевый алгоритм и что так можно

Console.WriteLine($"Максимальное число - {result}");


