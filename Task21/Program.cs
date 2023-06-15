// Напишите программу, которая
// принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод координат двух точек
Console.WriteLine("Введите x координату точки A:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y координату точки A:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z координату точки A:");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x координату точки B:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y координату точки B:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z координату точки B:");
double z2 = Convert.ToDouble(Console.ReadLine());


//Далее формула нахождения расстояния между точками d = √((x2-x1)² + (y2-y1)² + (z2-z1)²)
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(string.Format("Расстояние между точками : {0:F2}", distance));

//string.format использовался для округления числа F2 до 2 чисел после запятой