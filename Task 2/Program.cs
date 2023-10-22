// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int x = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = Int32.Parse(Console.ReadLine());

int max = x;
if (y > max) max = y;
if (z > max) max = z;

Console.WriteLine(max);