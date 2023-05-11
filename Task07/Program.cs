// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.WriteLine($"Последнея цифра числа {number} => {lastNumber} ");
}
else Console.WriteLine("Некоректный ввод ");
