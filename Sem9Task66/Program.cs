// адача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

int RecSumMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return  m + RecSumMN(m +1, n);
    }
    
}




int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

int res =  m < n? RecSumMN ( m, n):RecSumMN ( n, m); // защита от дурака
PrintResult($"Сумма натуральных чисел = " + res);
