//Задача 26.
// Напишите программу, которая
// 1. принимает на вход число и
// 2. выдает количество цифр в чисел

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = CountNumbers(number);

Console.WriteLine ($"Количество цифр в числе {number} = {count}");

int CountNumbers (int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

// /*
// 1. 89126/10=8912
// i = 1
// 2. 8912/10=891
// i = 2
// 3. 891/10=89
// i = 3
// 4. 89/10=8
// i = 4
// 5. 8/10=0
// i = 5