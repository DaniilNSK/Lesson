// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Week(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 6 || a == 7)
        { Console.WriteLine("Выходной день"); }
        else { Console.WriteLine("Будний день"); }
    }
    else { Console.WriteLine("Некорректное число"); }
}
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
Week(number);
