// Задача 28. Напишите программу, которая
// 1. принимает на вход чсило N и
// 2. выдает произведение чисел от 1 до N (факториал чисел)

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(numberN);
Console.WriteLine($"Факториал числа {numberN} = {factorial}");

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;

}
