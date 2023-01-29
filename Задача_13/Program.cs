Console.Clear();

Console.Write("Введите трехзначное число: ");
string x = Console.ReadLine();
int num = int.Parse(x);

if(num > -100 && num <100)
{
    Console.WriteLine("Нет 3 цифры");
    return;
}
else
{
    string y = Convert.ToString(x[2]);
    Console.WriteLine($"{x} - > {y}");
}