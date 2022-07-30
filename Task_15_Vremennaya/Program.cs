// проверка на кратность. Кратно ли второе число первому? вывести остаток от деления

Console.Write("Введите первое число: ");
string? inNum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inNum2 = Console.ReadLine();

if (inNum1 != null && inNum2 != null)
{
    int num1 = int.Parse(inNum1);
    int num2 = int.Parse(inNum2);
    int div = num2 % num1;

    if (div == 0)
        Console.WriteLine("Второе число кратно первому");
    else
        Console.WriteLine("Второе число не кратно первому, остаток от деления = " + div);
}