﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int LineTwoDimensionalArray()
{
    Console.Write("Введите колличество строк в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return LineTwoDimensionalArray();
    }
    else
    {
        return line;
    }
}

int ColumnTwoDimensionalArray()
{
    Console.Write("Введите колличество столбцов в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int column);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return ColumnTwoDimensionalArray();
    }
    else
    {
        return column;
    }
}

int[,] MakeTwoDimensionalArray()
{
    int line = LineTwoDimensionalArray();
    int column = ColumnTwoDimensionalArray();
    int[,] array = new int[line, column];
    return array;
}

int RandomNumbersStart()
{

    Console.Write("Введите начало отрезка рандомных цифр для заполнения массива: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return RandomNumbersStart();
    }
    else
    {
        return start;
    }

}

int RandomNumbersEnd()
{
    Console.Write("Введите конец отрезка рандомных цифр для заполнения массива: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return RandomNumbersEnd();
    }
    else
    {
        return finish;
    }
}

int[,] FillTwoDimensionalArray(int[,] array, int startRandom, int finishRandom)
{
    Random random = new Random();
    int startValue = startRandom;
    int endValue = finishRandom;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = random.Next(startValue, endValue);
        }
    }
    return array;
}

void WriteTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

string FindNumber(int line, int column, int[,] array)
{
    string result = string.Empty;
    if (array.GetLength(0) < line || array.GetLength(1) < column)
    {
        result = "под такими позициями элемента в массиве не сущетсвует";
        return result;
    }

    {
        result = Convert.ToString(array[line, column]);
        return result;
    }
}

int[,] array = MakeTwoDimensionalArray();

int startRandom = RandomNumbersStart();
int finishtRandom = RandomNumbersEnd();

array = FillTwoDimensionalArray(array, startRandom, finishtRandom);

WriteTwoDimensionalArray(array);
Console.WriteLine();

try
{
    Console.Write("Введите число строку поиска в массиве: ");
    int x = Int32.Parse(Console.ReadLine());
    Console.Write("Введите число столбец поиска в массиве: ");
    int y = Int32.Parse(Console.ReadLine());
    string result = FindNumber(x, y, array);
    Console.WriteLine($"Результат : {result}");
}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}
