   /// Банковская программа. Принимает на вход число, на выходе выводит сумму с учетом начисленных процентов.
   using System;
 
namespace FinalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
             
            if (sum < 100)
            {
                sum += sum * 0.02;
            }
            else if (sum <= 200)
            {
                sum += sum * 0.08;
            }
            else
            {
                sum += sum * 0.2;
            }
            Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
 
            Console.ReadKey();
        }
    }
}