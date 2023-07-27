// Задача 2 Нахождение большего из двух чисел
Console.WriteLine("Enter the number1");
string answer1 = Console.ReadLine() ?? "";
int number1 = int.Parse(answer1);
Console.WriteLine("Enter the number2");
string answer2 = Console.ReadLine() ?? "";
int number2 = int.Parse(answer2);
if (number1 > number2)
{
    Console.WriteLine($"{number1} > {number2}");
}
else Console.Write($"{number2} > {number1}");
