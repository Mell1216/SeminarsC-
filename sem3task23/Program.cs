// Напишите программу, которая принимает на вход число N и выдаёт таблоцу кубов чисел от 1 до N

double cubo(double arg)
{
    arg = Math.Abs(arg);
    
    double count = 0;
    double x = 1;

    while (x <= arg)
    {

        if (x == arg)
        {
            count = Math.Pow(x, 3);

            System.Console.Write(count);

            break;
        }

        count = Math.Pow(x, 3);

        System.Console.Write($"{count}, ");

        x++;
    }
    return count;
}

System.Console.Write("Введите число N: ");
double n = double.Parse(Console.ReadLine());

cubo(n);