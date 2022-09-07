// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void SecondNumber(int a)
{
    int number = a;
    if (number > 99)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"Третья цифра числа {a} = {result}");
    }
    else if (number < -99)
    {
        number = number * -1;
        while (number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"Третья цифра числа {a} = {result}");
    }
    else { Console.WriteLine("третьей цифры нет"); }


}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

SecondNumber(number);
