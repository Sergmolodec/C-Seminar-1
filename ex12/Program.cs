// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34 -> 5 не кратно, остаток 4
Console.Clear();
Console.WriteLine("Enter the number1");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Enter the number2");
int num2 = int.Parse(Console.ReadLine() ?? "");

int result = num1 % num2;

if (result == 0)
    Console.WriteLine($"Kratnoe {num1} {num2} ");
else
    Console.WriteLine($"Nekratnoe {num1} {num2} ostatok {result}");