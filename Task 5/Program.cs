// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите число: ");
int number = Int32.Parse(Console.ReadLine());

int result = 0;
if (number < 1000)
{
    if(number >= 100)
    {
    result = number % 10;
    }
}

Console.WriteLine(result);