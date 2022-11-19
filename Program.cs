// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine()!;

// if (number.Length != 5) Console.WriteLine("Введено неверное число.");
// else {
//     if (number[0]==number[4] && number[1]==number[3])
//     Console.WriteLine("Введенное число является палиндромом.");
//     else Console.WriteLine("Введенное число не является палиндромом.");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите x первой точки: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите y первой точки: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите z первой точки: ");
// int z1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите x второй точки: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите y второй точки: ");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите z второй точки: ");
// int z2 = int.Parse(Console.ReadLine()!);
// double distance = Math.Sqrt((Math.Pow((x2-x1),2)+(Math.Pow((y2-y1),2))+(Math.Pow((z2-z1),2))));
// Console.WriteLine($"Расстояние между точками составляет {distance:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// double index = 1;
// while (index<=N)
// {
//     Console.WriteLine(Math.Pow(index,3));
//     index++;
// }
