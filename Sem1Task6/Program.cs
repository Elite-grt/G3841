// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string? inputNum1 = Console.ReadLine()??"0";
int namber1 = int.Parse(inputNum1);

if(namber1%2==0)
{

    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}