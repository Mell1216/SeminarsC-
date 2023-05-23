// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num < 1000 & num > 100 )
{
    int sec = num % 100;
    int def = sec / 10;
    Console.WriteLine(def);
}


num = new Random().Next(100, 1000);
int secNum = num / 10 % 10;
Console.WriteLine($"Вторая цифра ы числе {num} ---> {secNum}"); 