// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void SmallSumRowArray(int[,] array)
{
    int [] sum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = array[i, j] + sum[i];
            
        }
        Console.WriteLine($"Сумма элементов строки {i} = {sum[i]}");
    }
      int result = sum[0];
      int numberSrting = 0;
      for (int i = 1; i < sum.Length; i++)
      {
        if (sum[i] < result )
        {
            result = sum[i];
            numberSrting = i;
        }
      }
   

    Console.WriteLine($"Номер строки {numberSrting} с наименьшей суммой элементов:{result}");
}

int[,] myArr = new int[4, 4];

Random ran = new Random();

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = ran.Next(1, 4);
        Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}

SmallSumRowArray(myArr);