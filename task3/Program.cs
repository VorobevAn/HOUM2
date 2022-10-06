

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели: ");
int namber = int.Parse(Console.ReadLine()!);

if (namber == 1)
{
    Console.WriteLine($"{namber} -> нет");
}
if (namber == 2)
{
    Console.WriteLine($"{namber} -> нет");
}
if (namber == 3)
{
    Console.WriteLine($"{namber} -> нет");
}
if (namber == 4)
{
    Console.WriteLine($"{namber} -> нет");
}
if (namber == 5)
{
    Console.WriteLine($"{namber} -> нет");
}
if (namber == 6)
{
    Console.WriteLine($"{namber} -> Да");
}
if (namber == 7)
{
    Console.WriteLine($"{namber} -> Да");
}
else
{
 Console.WriteLine($"{namber} -> Не является днём недели");
}