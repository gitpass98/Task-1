// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
double[,] array = new double[m, n]; // создаем двумерный массив размером m×n
FillArrayRandomNumbers(array);
PrintArray(array);

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}