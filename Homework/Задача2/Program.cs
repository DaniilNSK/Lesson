//Программа, которая навход принимает два числа и выдает какое число большее,а какое меньшее

//Определение входных чисел
Console.Write("Введите число: ");
int numberA = int.Parse (Console.ReadLine());

Console.Write("Введите число: ");
int numberB = int.Parse (Console.ReadLine());

// Использовав математическую функцию нахождения максимума, определяем максимальное число
int maxNumber = Convert.ToInt32(Math.Max(numberA,numberB));
Console.WriteLine($"Большее число {maxNumber}"); 

//Использовав математическую функцию нахождения минимума, определяем максимальное число
int minNumber = Convert.ToInt32(Math.Min(numberA,numberB));
Console.WriteLine($"Меньшее число {minNumber}"); 


