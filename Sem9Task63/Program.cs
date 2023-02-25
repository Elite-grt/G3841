// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------

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

// 1 2 3 4 5 ..... n
// n = 5

//задЧисло //формируем строки
// num = 5   5_4_3_2_1_"" - 
// num = 4     4_3_2_1_""
// num = 3       3_2_1_""
// num = 2         2_1_""
// num = 1           1_""
// num = 0            "" - вернет пустую строчку
//

// Рекурентная ф-ция
string LineGenRec(int num)  //Для создания строки и значения которое введем
{
    if (num == 0)  // ПРАВИЛО 2: точка остановки
    {
        return string.Empty; // Возращает пустую строку
    }
    else
    {
        return LineGenRec(num - 1) + " " + num ; // ПРАВИЛО 1: уменьшаем всегда значение (num - 1)
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);
