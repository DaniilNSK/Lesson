// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akerman(int m, int n)
{

    if (m == 0)
    {
        return n = n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
    throw new Exception("неверные числа");
}

Console.WriteLine("Здраствуйте, введите пожайлуста значение m : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Здраствуйте, введите пожайлуста значение n : ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Akerman(number1, number2);
Console.WriteLine($"Результат функции вычисления Аккермана : A({number1},{number2}) = {result}");