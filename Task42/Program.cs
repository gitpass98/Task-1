// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

string result = DecToBin(number); //вызываем метод
Console.WriteLine(result);

string DecToBin (int num) // наименование метода
{
     string res = string.Empty; //вводим переменную; res -это result
     while (num > 0)
     {
        res = num % 2 + res; //создаем цикл, делим с остатком и прибовляем результат
        num = num / 2; // делим на 2
     }
     return res;
}