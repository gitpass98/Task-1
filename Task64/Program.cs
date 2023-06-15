// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int N = Prompt("Введите число N = ");
PrintNumbers(N);

void PrintNumbers(int N)
{
    if (N == 0)
        return;
   Console.WriteLine(N);
   PrintNumbers(N - 1);
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}