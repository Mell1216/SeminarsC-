// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным

System.Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    System.Console.WriteLine("В неделе 7 дней");
}

if (number == 6 | number == 7)
{
    System.Console.WriteLine("Выходной");
}

if (number > 0 & number < 6)
{
    System.Console.WriteLine("Будний день");
}
