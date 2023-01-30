// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

char[] digit = (Console.ReadLine() ?? "0").ToCharArray();


if (digit.Length >= 3)
{
    // вызываем второй элемент масива
    Console.WriteLine(digit[2]);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}
