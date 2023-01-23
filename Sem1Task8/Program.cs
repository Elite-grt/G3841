// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string? inputNum = Console.ReadLine()??"0";

if(inputNum!=null)
{

        int N = int.Parse(inputNum);

        string? R = string.Empty;

           for(int i = 2; i < N; i = i+2)
           { 
           R = R + i + ",";
           }

           if (N%2==0)
           R = R + N; 

        Console.WriteLine(R);

}

