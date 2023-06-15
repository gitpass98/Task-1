// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

    {
        double[] nums = { 3.5, 7.1, 22.9, 2.3, 78.5 };

        Console.WriteLine("Массив чисел:");
        PrintArray(nums);

        double diff = GetDifference(nums);
        Console.WriteLine("Разница между максимальным и минимальным элементами: {0}", diff);

        Console.ReadKey();
    }

    double GetDifference(double[] arr)
    {
        double max = arr[0];
        double min = arr[0];

        foreach (double num in arr)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        return max - min;
    }

    void PrintArray(double[] arr)
    {
        foreach (double num in arr)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }