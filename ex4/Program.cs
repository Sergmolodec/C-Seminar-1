// Нахождение максимального из трёх чисел 
Console.WriteLine("Enter the number1");
string answer1 = Console.ReadLine() ?? "";
int number1 = int.Parse(answer1);
Console.WriteLine("Enter the number2");
string answer2 = Console.ReadLine() ?? "";
int number2 = int.Parse(answer2);
Console.WriteLine("Enter the number3");
string answer3 = Console.ReadLine() ?? "";
int number3 = int.Parse(answer3);

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write($"{"max = "} -> {max}");