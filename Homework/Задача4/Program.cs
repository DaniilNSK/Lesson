// Программа,которая принимает на вход три числа и выдает максимальное

//Определение входных чисел
Console.Write("Введите число: ");
int numberA = int.Parse (Console.ReadLine());

Console.Write("Введите число: ");
int numberB = int.Parse (Console.ReadLine());

Console.Write("Введите число: ");
int numberС = int.Parse (Console.ReadLine());

// Использовав математическую функцию нахождения максимума, определяем максимальное число между двумя первыми числами.
int maxNumber1 = Convert.ToInt32(Math.Max(numberA,numberB));
//Использовав математическую функцию нахождения максимума, определяем максимальное число между максимумом первых двух чисел и третим
int maxNumber2 = Convert.ToInt32(Math.Max(maxNumber1,numberС));

Console.WriteLine($"Большее число {maxNumber2}"); 