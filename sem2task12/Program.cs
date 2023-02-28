// Напишите программу, которая принимает на вход два числа и выводит, является ли второе число кратно первому.
// И если не кратно, то выводит остаток

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 % num2;

if(sum == 0)
{
    Console.WriteLine($"Число кратно {num2}");
}
else
{
    Console.WriteLine($"Число некратно {num2}");
    Console.WriteLine($"Остаток от деления {sum}");
}