// определяем выходной 
Console.WriteLine("Введите число от 1 до 7");
string? inNumber = Console.ReadLine();

if (inNumber != null)
{
    int number = int.Parse(inNumber);
    if ((0 < number) && (number < 8))
    {
        if ((number == 6) || (number == 7)) Console.WriteLine("Ура! Выходной");
        else Console.WriteLine("это не выходной");
    }
    else Console.WriteLine("простите, мы не можем определить день недели");
}
Console.WriteLine();

