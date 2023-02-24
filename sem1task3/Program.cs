// По числу день недели

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
         Console.Write("Понедельник");
         break;
    case 2:
         Console.Write("Вторник");
         break;
    case 3:
         Console.Write("Стреда");
        break;
    case 4:
         Console.Write("Четверг");
        break;
    case 5:
         Console.Write("Пятница");
        break;
    case 6:
         Console.Write("Суббота");
         break;
    case 7:
          Console.Write("Вторник");
          break;
    default:
         Console.Write("Вы ввели не день недели");
         break;

}
