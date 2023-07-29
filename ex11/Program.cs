// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру из этого числа. 456 -> 46, 782 -> 72
Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;

int result = a1 * 10 + a3;

Console.WriteLine($"Two-digit number {num} -> {result}");
