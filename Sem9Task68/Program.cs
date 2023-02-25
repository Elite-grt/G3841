// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using System.Numerics;

BigInteger ReadData(string line)
{
    Console.Write(line);
    return BigInteger.Parse(Console.ReadLine() ?? "0");
}

// функция Аккермана
BigInteger Akkerman(BigInteger n, BigInteger m)
{
    if (n == 0) // если n=0
        return m + 1; // возращаем
    else                // иначе
      if ((n != 0) && (m == 0)) // если m=0
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}



BigInteger m = ReadData("Введите число M: ");
BigInteger n = ReadData("Введите число N: ");

BigInteger funcAkk = Akkerman(m, n);

Console.Write($"Функция Аккермана = {funcAkk} ");