// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

        int[] arr = new int[8]; // Создание массива из 8 элементов
        Random rnd = new Random(); // Создание объекта генерации случайных чисел

        // Заполнение массива случайными числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 101); // Случайное число от 1 до 100
        }

        // Вызов метода для нахождения суммы элементов, стоящих на нечётных позициях
        int sum = GetSumOfOddPositions(arr);

        Console.WriteLine("Массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);


    // Метод для нахождения суммы элементов, стоящих на нечётных позициях
    int GetSumOfOddPositions(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }