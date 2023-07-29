//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//       6 -> да    7 -> да    1 -> нет
Console.Clear();
Console.WriteLine("Vvedite chislo: ");
string answer1 = Console.ReadLine() ?? "";
int number = int.Parse(answer1);
if (number == 1)
Console.WriteLine("Rabochiy den");
else if (number == 2)
    Console.WriteLine("Rabochiy den");
else if (number == 3)
    Console.WriteLine("Rabochiy den");
else if (number == 4)
    Console.WriteLine("Rabochiy den");
else if (number == 5)
    Console.WriteLine("Rabochiy den");
else if (number == 6)
    Console.WriteLine("Vychodnoy den");
else if (number == 7)
    Console.WriteLine("Vychodnoy den");
else
    Console.WriteLine("Net takogo dnja nedeli");