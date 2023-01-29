Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int num1 = num / 100;
int num2 = num % 100 ;
int num3 = num % 10;

Console.WriteLine($"{num} -> {(num2-num3)/10}");
