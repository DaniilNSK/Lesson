// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string GetTripleTable(int n)
{
    string tripleString = "";
  
    if(n<1)
    { 
        return "неверное число было введено Вами";
    }
    else 
    {
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}";
        }
        else
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}, ";
        }
    }
    return tripleString;

}
}

Console.Write("Input number: ");
int x = int.Parse(Console.ReadLine());
Console.Write($"Таблица кубов от 1 до {x} = {GetTripleTable(x)}");
