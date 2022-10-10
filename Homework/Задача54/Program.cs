// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] SortArrayDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int min = array[i, k];
           
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = min;
                }

            }
        }
    }
    return array;
}

static void Print(int[,] array)
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

int[,] myArr = new int[4, 7];

Random ran = new Random();
Console.WriteLine("Старый массив: ");

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = ran.Next(-5, 5);
        Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}



SortArrayDescending(myArr);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
Print(myArr);