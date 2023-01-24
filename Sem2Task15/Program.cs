// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int day = int.Parse(Console.ReadLine()??"0");
if (day>7 && day<1)
{
    Console.WriteLine("Это не день недели");
}
else
{
     if(day>5)
     {
       Console.WriteLine("Это не рабочий день"); 
     }
     else
     {
        Console.WriteLine("Это рабочий день");
     }

}