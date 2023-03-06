// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом
System.Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

palindrom(number);


void palindrom(int x)
{
x = Math.Abs (x);

int a;
int b;

if (x < 10000 || x > 99999)
{
    System.Console.WriteLine("Не пятизначное число");
}

else
{
    a = x / 1000;
    b = x % 100;

    if (a == b)
    {
        System.Console.WriteLine("Палиндром");
    }
    
    if (a > b)
    {
        b = b + 9;
        if (a == b)
        {
            System.Console.WriteLine("полиндром");
        }
        else
        System.Console.WriteLine("Не палиндром");
    }

    if (a < b)
    {
        a = a + 9;
        if (a == b)
        {
            System.Console.WriteLine("полиндром");
        }
        else
        System.Console.WriteLine("не полиндром");
    }
}
}

