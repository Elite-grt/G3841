﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();


if(inputNum1!=null && inputNum2!=null && inputNum3!=null)
{

int namber1 = int.Parse(inputNum1);
int namber2 = int.Parse(inputNum2);
int namber3 = int.Parse(inputNum3);

if(namber1 > namber2)
{

     if(namber1 > namber3)
     
        Console.WriteLine("Число 1 максимальное");
     

     else
     
        Console.WriteLine("Число 3 максимальное");
     

}

else
{
      if(namber2 > namber3)
      
        Console.WriteLine("Число 2 максимальное");
      
 
      else
      
        Console.WriteLine("Число 3 максимальное");
    

}

}
