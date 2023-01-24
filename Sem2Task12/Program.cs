// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратно первому. Если второе число не кратное первому, то программа выводит остаток от деления.

int Nam1 = int.Parse(Console.ReadLine()??"0");
int Nam2 = int.Parse(Console.ReadLine()??"0");

int res = Nam2%Nam1;

// Если res = 0
if(res==0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Не кратно "+res);
}





