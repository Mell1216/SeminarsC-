// Принимет трёхзначное число и выдает последнюю цифру числа

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int result = num % 10;
Console.WriteLine(result);
