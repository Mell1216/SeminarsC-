// Программа, которая принимает на вход одно число N, и показывает все целые числа от -N до N.

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int count = -N-1;
int num = 0;

if (N > 0)
{
    while(count < N)
    {
        num = count + 1;
        Console.WriteLine(num);
        count ++;
    }
}
else
{
    Console.Write("Некорректное число");
}
