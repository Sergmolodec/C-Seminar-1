// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Enter the number1");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Enter the number2");
int num2 = int.Parse(Console.ReadLine() ?? "");
int a = num1 * num1;
int b = num2 * num2;

if (num1 == b)
    Console.WriteLine("Pervoe chislo yavlajetsa kvadratom vtorogo");
else if (num2 == a)
    Console.WriteLine("Vtoroe chislo yavlajetsa kvadratom pervogo");
else
    Console.WriteLine("Ni odno chislo ne javlyaetsa kvadratom drugogo");