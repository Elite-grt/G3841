// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Вариант 1
// Счет количества чисел
int SumDigit(int num)
{
    int res =0;
    while(num>0)
    {
        res++;   // накопление результата
        num=num/10;
    }
    return res;
}

// Вариант 2

int SumDigStr(int num)
{
    int res =0;
    res = num.ToString().Length;  // Возращаем в строку(ToString) и вызовим в длину(Length)
    return res; 
}

// Вариант 3

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1; // Считаем логорифм числа
    return count;
}
// Варианты через методы

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Вариант (SumDigit): ",res1);

// Метод String
DateTime d2 = DateTime.Now;
int res2 = SumDigStr(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Вариант (SumDigStr): ",res2);

// Метод Log
DateTime d3 = DateTime.Now;
int res3 = VariantLog(number);
Console.WriteLine(DateTime.Now - d3);
PrintData("Вариант (VariantLog): ",res3);

