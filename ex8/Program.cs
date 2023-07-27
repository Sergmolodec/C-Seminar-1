// Напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Enter the number: ");
string answer = Console.ReadLine() ?? "";
int number = int.Parse(answer);
if (number <= 0)
{
    Console.WriteLine("Not correct number");
    return;
}
int i = 2;
while (i <= number)
{
    Console.Write($"{i} ");
    i = i + 2;
}