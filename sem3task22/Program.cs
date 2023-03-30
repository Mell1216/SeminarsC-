// Принимает на вход число N, и выдаёт таблицу квадратов от 1 до N

Console.WriteLine("Введите число N: ");
int N = new Random().Next(1, 100);
int array = 1;

while (array <= N)
{
    Console.WriteLine(array * array);
    array++;
}