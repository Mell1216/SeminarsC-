// 99




Console.WriteLine("Введите число: ");
double input1 = double.Parse(Console.ReadLine());

if (input1 < 100)
{    
    Console.WriteLine($"{input1+(input1 * 0.05)}");
}
else if (input1 > 100 && input1 < 200 )
{    Console.WriteLine($"{input1+(input1 * 0.07)}");
}
else
{    
    Console.WriteLine($"{input1+(input1 * 0.1)}");
}
