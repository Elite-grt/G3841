// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод преобразовывает десятичные числа в двоичные
string Convert10to2 (int num)
{
    string result = string.Empty;
    while(num>=1)
    {
        result = Convert.ToString(num%2) + result;
        num=num/2;
    }
    return result;
}

string result = Convert10to2(ReadData("Введите число: "));
Console.WriteLine(result);