// ЯвляеТся ли одно число квадратом другого

Console.WriteLine("Введите первое число");
string? inNum1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inNum2 = Console.ReadLine();
if (inNum1 != null && inNum2 != null)
{
    int num1 = int.Parse(inNum1);
    int num2 = int.Parse(inNum2);

    if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1)
    {
        Console.WriteLine ("одно число является квадратом другого");
    }
    else Console.WriteLine ("одно число не является квадратом другого");
}
