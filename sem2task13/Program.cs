// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}

if (number > 99)
{
     while (number > 999)
     {
         number = number / 10;
    }
     number %= 10;
     System.Console.WriteLine(number);
}
