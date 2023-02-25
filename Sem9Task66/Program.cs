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

int RecSumMN(int M, int N)
{
    if (M >= N)
    {
        return N;
    }
    else
    {
        return  M + RecSumMN(M +1, N);
    }
    
}




int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

int res =  M < N? RecSumMN ( M, N):RecSumMN ( N, M); // защита от дурака
PrintResult($"Сумма натуральных чисел = " + res);
