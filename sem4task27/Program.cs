// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int sumnumbers(int x)
{
    int result = 0;
    int y = 0;

    while (x != 0)
    {
        y = x % 10;
        x = x / 10;
        result = result + y;
    }

    return result;
}

System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int sum = sumnumbers(n);
System.Console.WriteLine($"Сумма цифр в числе: {sum}");
