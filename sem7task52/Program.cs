﻿﻿// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void PrintArray(int[,] tableArray)
{
    Console.WriteLine();
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write($"{tableArray[i, j]}      ");
        }
        Console.WriteLine();
    }
}


int[,] GenerateArray(int numberRow, int numberColumn, int numberStart, int numberEnd)
{
    Random random = new Random();
    int[,] tableArray = new int[numberRow, numberColumn];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = random.Next(numberStart, numberEnd+1);
        }
    }
    return tableArray;
}


string GetAverageArithmetic(int[,] tableArray)
{
    string averageArithmeticList = " ";
    double sumElementcColumn = 0;
    for (int j =  0; j <  tableArray.GetLength(1); j++) 
    {
        sumElementcColumn=0;
        for (int i = 0; i < tableArray.GetLength(0); i++) 
        {
           sumElementcColumn+=tableArray[i,j]; 
        }
        averageArithmeticList = averageArithmeticList +j+" столбце = "+Math.Round(sumElementcColumn/tableArray.GetLength(0),2)+"; ";
    }
    return averageArithmeticList;
} 


int numberRow = Prompt("Введите значение количества строк массива: ");
int numberColumn = Prompt("Введите значение количества столбцов массива: ");
int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[,] tableArray = GenerateArray(numberRow,numberColumn,numberStart,numberEnd);
PrintArray(tableArray);
string averageArithmeticList = GetAverageArithmetic(tableArray);

Console.WriteLine($"Среднее арифметическое: {averageArithmeticList}");
