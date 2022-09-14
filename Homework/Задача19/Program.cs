// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetWholeDigitCount(int x)
{
    int count = 1;
    while ((x /= 10) > 0) ++count;
    return count;
}

string CheckPalindrome2(int x)
{
    if (x < 10)
    {
        return "нет";
    }
    else
    {
        int copyX = x;
        int DigitCount = GetWholeDigitCount(x);
        int[] nums1 = new int[DigitCount];
        int[] nums2 = new int[DigitCount];
        for (int i = 0; i < DigitCount; i++)
        {
            nums1[i] = copyX % 10;
            nums2[DigitCount - (i + 1)] = copyX % 10;
            copyX = copyX / 10;
        }
        if (nums1.SequenceEqual(nums2))
        {
            return "да";
        }
        else
        {
            return "нет";
        }
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

string result = CheckPalindrome2(num);

Console.Write($"Число {num} является палиндромом?: {result}");