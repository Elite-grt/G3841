// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] num = new int[8];

Console.Write("[");
for (int i = 0; i < num.Length; i++)
 {
    num [i] = new Random().Next(0, 15);
    Console.Write(" " + Method (i) + ", ");
 }
Console.WriteLine((num.Length-1)+" ]");

int Method (int a)
{
    return num[a];
}

