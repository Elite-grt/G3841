// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод, читает данные от пользователя
string ReadData(string msg)
{
    // Выводим сообщение
    Console.WriteLine(msg);
  
    // Считаем строку 
    string inputLine = Console.ReadLine() ?? "";
    // Возращаем значение
    return inputLine;
}

// Метод, принимает строку, выводит в консоль 
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


// Метод, возращающий словарь 4-значных палиндромов
Dictionary<int, int> FillPalindroms()
{
    Dictionary<int, int> palindroms = new Dictionary<int, int>();

    // Цикл внутри цикла, заполняющих значения словаря палиндрома
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindroms.Add(key, value);
        }
    }
    return palindroms;
}

// Метод, проверяющий на палиндром
bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindrom)
{

    // Делаем из исходного 5-значного числа 4-значное, убирая 3ю цифру
    int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;

    // Проверям на вхождение в словарь палинромов
    return palindrom.ContainsValue(fourDigitNumber);
}

int inputNumber = 0;
string inputLine = ReadData("Введите 5и значное число: ");
if (int.TryParse(inputLine, out inputNumber))
{
    if (inputNumber > 9999 && inputNumber < 100000)
    {
        Dictionary<int, int> fourDigitPalindrom = FillPalindroms();
        PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindrom) ? "Это палиндром" : "Это не палиндром");
    }
    else
    {
        PrintResult("Это не пятизначное число");
    }
}
else
{
    PrintResult("Это не пятизначное число");
}