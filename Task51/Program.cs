// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // опредлеяем количество строи и столбцов
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = matrix.GetLength(0); i  соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //  columns = matrix.GetLength(1); j соответствует столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

int SumElementsOnDiagonal(int[,] matr)
{
    int sum = 0;
    int size = matr.GetLength(0) > matr.GetLength(1) ? matr.GetLength(1) : matr.GetLength(0);
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum += matr[i, i];
    }
    return sum;
}

Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массив");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rows2, columns2, minimum, maximum); // лучше пользовательский код
PrintMatrix(array2d);
int sumElementsOnDiagonal = SumElementsOnDiagonal (array2d);
Console.WriteLine($"Массив элементов главной диагонали равна {sumElementsOnDiagonal} ");