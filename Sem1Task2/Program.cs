// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Считаем данные с консоли
string? inputNum1 = Console.ReadLine()??"0";
string? inputNum2 = Console.ReadLine()??"0";

//Парсим введенное число
int namber1 = int.Parse(inputNum1);
int namber2 = int.Parse(inputNum2);

if(namber1>namber2)
{
   //Выводим данные в консоле
   Console.WriteLine("Число 1 больше числа 2"); 
}
else
{
    Console.WriteLine("Число 2 больше числа 1");
    
}
