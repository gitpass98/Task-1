// Задача22
// Напишите программу, которая
// принимает на вход число (N)
//и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
//2 -> 1, 4

Console.WriteLine("Введите положительное целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Square(numberN);

void Square(int num)

{
    int count  = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} {count * count,5}");
        count++;
    }
}