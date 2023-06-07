// Напишите программу, которая 
// принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трехзначное чило ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
 

int DeleteSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int needDigit = firstDigit	* 10 + thirdDigit;
    return needDigit;
}

Console.WriteLine($"Введите число `{number}`");
int secondDigit = number / 10 % 10;


Console.WriteLine($"{number} -> {secondDigit}");