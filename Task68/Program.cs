// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int M = Prompt("Введите число M = ");
int N = Prompt("Введите число N = ");
PrintNumbers(M,N);


void PrintNumbers(int M, int N)
{
Console.WriteLine($"Значение функции Аккермана для ({M}, {N}) =  {Ackermann(M, N)}");

}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}