// Напишите цикл, который принимает на вход два числа (A и B) и выводит число А в натуральную степень В

double step(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

System.Console.Write("Введите число A: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Введите число B: ");
double b = double.Parse(Console.ReadLine());

double number = step(a, b);
System.Console.WriteLine($"{a} в степени {b} = {number}");
