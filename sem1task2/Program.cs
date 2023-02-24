// Какое число больше

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = 0;

if (num1 > num2)
{
    max = num1;
    Console.Write(max);
}
else
{
    max = num2;
    Console.Write(max);
}
