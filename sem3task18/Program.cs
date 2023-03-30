// // Семинар3 задача вместе с группой. Задача на точки

Console.WriteLine("Введите номер четверти: ");
int digit = int.Parse(Console.ReadLine());


switch (digit)
{
    case 1: 
    Console.WriteLine("x > 0; y > 0");
    break;
    case 2:
    Console.WriteLine("x < 0; y < 0");
    break;
    case 3:
    Console.WriteLine("x > 0; y < 0");
    break;
    case 4:
    Console.WriteLine("x < 0; y > 0");
    break;
    default:
    Console.WriteLine("Не номер четверти");
    break;
}

