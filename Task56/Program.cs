// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] array = new int[m, n]; // создаем двумерный массив размером m×n
FillArrayRandomNumbers(array);

Console.WriteLine("Исходный массив");
PrintArray(array);

int minSumRowIndex = FindMinSumRow(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(100));
        }
    }
}

int FindMinSumRow(int[,] array)
{
    int minSum = int.MaxValue; // начальное значение минимальной суммы
    int minSumRowIndex = -1; // начальное значение индекса строки с минимальной суммой

    // перебираем строки в массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0; // переменная для суммы элементов строки

        // перебираем элементы в строке
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j]; // суммируем элементы в строке
        }

        // если сумма в текущей строке меньше минимальной,
        // обновляем минимальное значение и индекс строки
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex; // возвращаем индекс строки с наименьшей суммой
}


void PrintArray(int[,] array)
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