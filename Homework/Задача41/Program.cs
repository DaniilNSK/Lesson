// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputNumbers (int quantityNumber)
{
    int[] massiveNumbers = new int[quantityNumber];
    for (int i = 0; i < quantityNumber; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massiveNumbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

int NumbersMorethanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

try
{
    Console.Write($"Введи число М(количество чисел): ");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] numbers = InputNumbers(x);
    Console.Write($"Наш массив: ");
    PrintArray(numbers);
    int result = NumbersMorethanZero(numbers);
    Console.WriteLine("");
    Console.WriteLine($"Ввведено чисел больше 0 : {result} ");
}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}