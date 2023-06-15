// Задача 40: Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первую сторону треугольника A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника C = ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool existTriangle = IsExistTriangle(numberA, numberB, numberC);

Console.WriteLine(existTriangle ? "Существует": "Не существует ");

// ($"Треугольник со сторонами {numberA}, {numberB}, {numberC} может существо")

bool IsExistTriangle (int a, int b, int c)
{
    if (a+b > c && a+c > b && b+c > a) return true; // return a+b > c && a+c > b && b+c > a
    else return false;
}