// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Ввод числа экрана
int Prompt(string message)
{
    System.Console.Write(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат

}

//метод получения случайных значений массива
int [] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int[] array = new int[Lenght]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными цифрами из диапазона SatrArr до EndArr
    
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); // вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]})"); //вывод значения массива
    System.Console.Write("]");
}

int lenght = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
int [] array = GenerateArray(lenght, min, max); //заполнение массива слуайными числами
PrintArray(array); //вывод массива