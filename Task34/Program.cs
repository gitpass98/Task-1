// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

 int[] arr = new int[4]; // Создание массива из 4 элементов
        Random rnd = new Random(); // Создание объекта генерации случайных чисел

        // Заполнение массива случайными числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 1000); // Случайное трёхзначное число
        }

        // Вызов метода для подсчёта количества чётных чисел и вывода массива
        int count = CountEvenNumbers(arr);

        Console.WriteLine("Массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Количество чётных чисел в массиве: " + count);


    // Метод, который считает количество чётных чисел в массиве и выводит сам массив
    int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }