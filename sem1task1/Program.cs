// Является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

if (numB == numA * numA)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}