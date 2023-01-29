Console.Clear();

Console.Write("Введите число: ");
int day = int.Parse(Console.ReadLine());

if(day < 1 || day > 7)
{
    Console.WriteLine("Ошибка. Напишите другой день.");
    return;
}

if(day == 6 || day == 7)
{
    Console.WriteLine("Это выходной день.");
}
else
{
    Console.WriteLine("Это рабочий день.");
}

