// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = Prompt("Введите число M = ");
int N = Prompt("Введите число N = ");
PrintNumbers(M,N);

void PrintNumbers(int M, int N)
{
    Console.WriteLine($"Сумма натуральных чисел в интервале [{M}, {N}]: {Sum(M, N)}");

}

int Sum(int M, int N)
{
    if (M == N)
        return M;
    else
        return M + Sum(M + 1, N);
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
