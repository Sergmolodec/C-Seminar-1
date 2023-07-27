// Напишите программу, которая на вход принимает число и выдает, является ли число четным. 
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
  Console.WriteLine("Number is not even");  
}
