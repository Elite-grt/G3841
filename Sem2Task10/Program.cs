//Задача 10:
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Namber = int.Parse(Console.ReadLine()??"0");
int res = Namber/10;
res = res%10;
Console.WriteLine(res);