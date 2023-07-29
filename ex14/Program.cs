// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine() ?? "");
int a = 7;
int b = 23;
int c = (num % a) + (num % b);
// if (num % a == 0 & num % b == 0)
if (c == 0)
    Console.WriteLine("Chislo kratno 7 i 23");
else
    Console.WriteLine("Chislo ne kratno 7 i 23");
