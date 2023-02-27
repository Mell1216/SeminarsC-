// Напишите программу, которая принимает случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.Write("Введите трёзначное число: ");
int num = new Random().Next(100, 1000);
int first = num / 100;
int sec = num % 10;

Console.WriteLine(num);
Console.Write(first);
Console.Write(sec);

int newD = first * 10 + sec;
