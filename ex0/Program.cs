Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? "");

int result = number * number;

Console.WriteLine(number + " -> " + result);

Console.WriteLine($"{number} ->{result}");