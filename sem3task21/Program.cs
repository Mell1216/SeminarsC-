// Опять задача на координаты

Console.WriteLine("Введите х1: ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите y1: ");
double y1 =double.Parse(Console.ReadLine());

Console.WriteLine("Введите х2: ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(x2 -x1 , 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(x);