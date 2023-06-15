// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


  int[,,] arr = FillArray();
  PrintArray(arr);

  Console.ReadKey();


    static int[,,] FillArray()
    {
        int[,,] arr = new int[2, 2, 2];
        Random rand = new Random();
        int[] usedNums = new int[100];
        int count = 0;

        // заполняем массив рандомными числами из неповторяющихся двузначных чисел
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    int num;
                    do
                    {
                        num = rand.Next(10, 100);
                    } while (Array.IndexOf(usedNums, num) != -1);
                    usedNums[count++] = num;
                    arr[i, j, k] = num;
                }
            }
        }

        return arr;
    }

    static void PrintArray(int[,,] arr)
    {
        // выводим массив построчно с индексами
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"arr[{i},{j},{k}] = {arr[i, j, k]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }