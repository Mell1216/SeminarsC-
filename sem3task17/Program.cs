// Задача на семинаре 17

Console.WriteLine("Введите Х: ");
int numX = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Х: ");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    Console.WriteLine("Секция 1");
}

else if (numX < 0 && numY > 0)
{
    Console.WriteLine("Секция 2");
}

else if (numX < 0 && numY < 0)
{
    Console.WriteLine("Секция 3");
}

else if (numX > 0 && numY < 0)
{
    Console.WriteLine("Секция 4");
}