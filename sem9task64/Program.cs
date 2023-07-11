// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

(int, int) CheckInput(int M, int N)
{
    M = Math.Abs(M);
    N = Math.Abs(N);

    if (N < M)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    return (M, N);
}
void GetEvenNumbers(int M, int N)
{

    if (M == N)
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}");
        }
    }
    else
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}, ");
        }
        M++;
        GetEvenNumbers(M, N);
    }
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

(M, N) = CheckInput(M, N);

Console.WriteLine($"Все четные числа из промежутка от {M} до {N} => ");
GetEvenNumbers(M, N);