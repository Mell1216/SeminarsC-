// Принимает три числа и выдаёт максимальное
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int max = 0;

if (num1 > num2 & num1 > num3)
{
    max = num1;
    Console.WriteLine($"MAX = {max}");
}
else
{
    if (num2 > num3)
    {
        max = num2;
        Console.WriteLine($"MAX = {max}");
    }    
    else
    {
        max = num3;
        Console.WriteLine($"MAX = {max}");

    }
    
}