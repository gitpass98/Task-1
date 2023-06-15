/// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] arr = new int[4, 4];
        FillSpiralArray(arr);
        PrintArray(arr);

        Console.ReadKey();


    void FillSpiralArray(int[,] arr)
    {
        int n = arr.GetLength(0);
        int num = 1;
        int row = 0;
        int col = 0;

        while (num <= n * n)
        {
            // заполняем строку слева направо
            for (int i = col; i < n - col; i++)
            {
                arr[row, i] = num++;
            }

            // заполняем столбец сверху вниз
            for (int i = row + 1; i < n - row; i++)
            {
                arr[i, n - col - 1] = num++;
            }

            // если спираль состоит из одной строки или одного столбца
            if (n - col - 1 == col || n - row - 1 == row)
            {
                break;
            }

            // заполняем строку справа налево
            for (int i = n - col - 2; i >= col; i--)
            {
                arr[n - row - 1, i] = num++;
            }

            // заполняем столбец снизу вверх
            for (int i = n - row - 2; i > row; i--)
            {
                arr[i, col] = num++;
            }

            row++;
            col++;
        }
    }

    void PrintArray(int[,] arr)
    {
        // выводим массив
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0,-3}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }