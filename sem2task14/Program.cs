// Напишите программу, которая принимает на вход число и проверяет, и проверяет кратно ли оно одновременно двум числам

Console.WriteLine("Введите число: ");
int sum = int.Parse(Console.ReadLine());

int num1 = new Random().Next(1, 10);
int num2 = new Random().Next(1, 100);

if(num1 == 0 & num2 == 0)
{
    Console.Write($"Число {sum} кратно {num1} и {num2}");
}
else
{
    Console.WriteLine($"Числро {sum} не кратно ни {num1}, ни {num2}");
}