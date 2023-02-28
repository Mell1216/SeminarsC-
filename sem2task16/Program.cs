// Напишите программу, которая принимает на вход числа и проверяет, является ли одно квадратом другого

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 == Math.Pow(num2, 2))
{
    Console.WriteLine($"Второе число - {num2} является квадратом первого числа - {num1}");
}
else
{
    if(num2 == Math.Pow(num1, 2))
    {
        Console.WriteLine($"Первое число - {num1} является квадратом второго числа - {num2}");
    }
    else
    {
        Console.WriteLine($"Числа не являяются квадратами друг друга");
    }
}