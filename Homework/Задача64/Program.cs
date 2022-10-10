// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GapNumber(int x)
{
    string result = "";
    if (x == 1)
    {
        result = "1";
    }
    else
    {
        result = GapNumber(x - 1) + "," + $"{x}";
    }
    return result;
}

Console.WriteLine("Здраствуйте, введите пожайлуста значение N : ");
int number = Convert.ToInt32(Console.ReadLine());
string result = GapNumber(number);
Console.WriteLine($"Промежуток от 1 до {number}: {result}");