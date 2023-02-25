// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



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

// Рекурентная ф-ция
string LineGenRec(int num)  //Для создания строки и значения которое введем
{
    if (num == 0)  //  точка остановки
    {
        return string.Empty; // Возращает пустую строку
    }
    else
    {
        return LineGenRec(num - 1) + " " + num ; // уменьшаем  значение 
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);
