// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите любое чиcло ");
int number = Convert.ToInt32(Console.ReadLine());


bool ValidateNumber (int number)
{
    if (number < 100 )
    {
     Console.WriteLine("У заданного числа нет третьей цифры ");
    return false;
    }
    return true;
}
int GetThirdNumber (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

Console.WriteLine($"{number} -> {GetThirdNumber(number)}");