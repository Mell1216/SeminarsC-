// Какое число больше

int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);

if (num1 > num2)
{
    Console.WriteLine($"{num1} > {num2}");
}
else
{
     Console.WriteLine($"{num1} < {num2}");
}