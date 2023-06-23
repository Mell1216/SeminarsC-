// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void GetNumberPositive(int numM)
{
    string listNumber = " ";
    int count = 0;
    for (int i = 0; i <= numM; i++)
    {
        int numberUser = Prompt("Введите число: ");
        listNumber = listNumber + numberUser +", ";  

        if (numberUser > 0)
        {
           count ++;
        }

    }
    Console.WriteLine($"{listNumber} чисел больше 0 = {count}");
}


int NumberM = Prompt("Введите количество чисел M: ");

GetNumberPositive(NumberM);
