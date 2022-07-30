//Проверяем кратно ли число одновременно 7 и 23

Console.WriteLine("Введите число");
string? inNum = Console.ReadLine();

if (inNum != null)
{
    int num = int.Parse(inNum);
    if ((num % 7 == 0) && (num % 23 == 0)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}

