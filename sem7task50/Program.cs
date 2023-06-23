﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int Prompt(string message)
{
    Console.Write(message);
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


int[,] GenerateArray(int numberRows, int numberColumns, int numberStart, int numberEnd)
{
    Random random = new Random();
    int[,] tableArray = new int[numberRows, numberColumns];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = random.Next(numberStart, numberEnd+1);
        }
    }
    return tableArray;
}


void GetPositionElement(int[,] tableArray, int numRow, int numColumn)
{
    
    if (((0 <= numRow) && (numRow < tableArray.GetLength(0))) && ((0 <= numColumn) && (numColumn < tableArray.GetLength(1)))) 
    {
        object elementArray = tableArray.GetValue(numRow, numColumn);
        Console.WriteLine($"Элемент массива на позиции {numRow},{numColumn} = {elementArray}");
    }
    else Console.WriteLine($"Элемента массива на позиции {numRow},{numColumn} не существует!");
}
int numberRows = Prompt("Введите значение количества строк массива: ");
int numberColumns = Prompt("Введите значение количества столбцов массива: ");
int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[,] tableArray = GenerateArray(numberRows,numberColumns,numberStart,numberEnd);
PrintArray(tableArray);

int numRow = Prompt("Введите номер строки элемента массива: ");
int numColumn = Prompt("Введите номер столбца элемента массива: ");

GetPositionElement(tableArray, numRow, numColumn);