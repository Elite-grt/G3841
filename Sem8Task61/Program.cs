// Задача №61
// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

//Вычисляем факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i; // домножаем
    }
    return x;
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


//_ _ _ _ _ 1
//_ _ _ _  1 1
void PrintPascalTriangle(int nRow) // метод печатания, кол-во строк nRow
{
    for (int i = 0; i < nRow; i++) // сколько всего строк в нашнм треугольнике
    {

        for (int j = 0; j <= nRow - i; j++)
        {
            Console.Write(" "); // печатаем пробелы
        }

        for (int j = 0; j <= i; j++)
        {
            // создаём пробелы между элементами треугольника
            Console.Write(" ");
            //формула вычисления элементов треугольника
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);