// Принимает на вход число N, а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N");
int N = new Random().Next(1, 100);
int count = 0;

if (N < 0)
{
    while(count < N + 1)
    {
        count -= 2;
        Console.WriteLine($"{count}"); 
    }
}
else
{
    while (count < N - 1)
    {
        count += 2;
        Console.WriteLine(count);
    }
}
