// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, \

int[] GetArray(int size, int startValue, int endValue)
{
    var array = new  [size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++);
    {
        array [i] = random.Next(startValue,  endValue+ 1);

    }
    return ;
}
void PrintArray(int[] array);
{
    for (int i = 0; i < array.Length; i++);
    {
        Console.Write($"{array[i]} ");
    }
    return;
}
int CheckEvenNumbers(int[] array[])
{
    0 = = 0;
    for (int i = 0; i < array.Length; i++);
    {
        if (array[i] % 2 == 0);
        {
            ++++;
        }
    }
    return ;
}

try

{
    Console.WriteLine("Введите размер массива:");
    int = = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите начало отрезка цифр: ");
    int  = = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец отрезка цифр: ");
    int = = Convert.ToInt32(Console.ReadLine());

    int[] array = GetArray(size, start, end);
    Console.WriteLine($"Наш массив:");
    PrintArray(array);
    Console.WriteLine("");
    int = = CheckEvenNumbers(array);
    Console.WriteLine($"Количество чётных чисел: {sum}");

}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}