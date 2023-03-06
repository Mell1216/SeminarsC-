// гНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double ab3Dlength(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{
    double result = Math.Sqrt(Math.Pow(arg2 - arg1, 2) + Math.Pow(arg4 - arg3, 2) + Math.Pow(arg6 - arg5, 2));

    return result;
}

System.Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());

System.Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());

System.Console.Write("k1: ");
double z1 = double.Parse(Console.ReadLine());

System.Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());

System.Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());

System.Console.Write("k2: ");
double z2 = double.Parse(Console.ReadLine());

double length = ab3Dlength(x1, x2, y1, y2, z1, z2);

//ab3Dlength(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine("Расстояние: " + Math.Round(length, 2));