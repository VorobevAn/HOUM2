

//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int namber = int.Parse(Console.ReadLine()!);
int a = namber / 10 % 10;

Console.Write($"Вторая цифра числа {namber} -> {a}");