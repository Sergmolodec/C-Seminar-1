// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Vvedite chislo ot 100 do 999");
int num = int.Parse(Console.ReadLine() ?? "");
int a2 = num / 10 % 10;
    Console.WriteLine($"{num} -> {a2}");