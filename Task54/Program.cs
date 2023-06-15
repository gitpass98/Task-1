// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] array = new int[m, n]; // создаем двумерный массив размером m×n
FillArrayRandomNumbers(array);

Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine("Сортированный  массив");
SortRows(array);
PrintArray(array);

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

static void SortRows(int[,] arr)
{
    int rows = arr.GetLength(0); // получаем количество строк в массиве
    int columns = arr.GetLength(1); // получаем количество столбцов в массиве

    for (int i = 0; i < rows; i++) // проходим по каждой строке массива
    {
        for (int j = 0; j < columns - 1; j++) // проходим по каждому элементу строки, кроме последнего
        {
            for (int k = j + 1; k < columns; k++) // проходим по каждому элементу строки, начиная со следующего за j
            {
                if (arr[i, j] < arr[i, k]) // если текущий элемент меньше следующего за ним
                {
                    int temp = arr[i, j]; // сохраняем текущий элемент в переменную temp
                    arr[i, j] = arr[i, k]; // заменяем элемент на следующий за ним
                    arr[i, k] = temp; // заменяем следующий элемент на текущий
                }
            }
        }
    }
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