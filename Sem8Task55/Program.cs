// Задача №55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод транспарнирования
void TransArray(int[,] matr) // 
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++) // Идем по тролбцам - Элемент строки +1 (i+1)
        {
            k = matr[i, j]; // в К-а вносим элемент нашего массива (i,j)
            matr[i, j] = matr[j, i]; //зеркалем
            matr[j, i] = k; // в зеркальную позицию кладем К
        }
    }
}

// Метод для узнавания равности строк и столбцов
bool TestArray(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1)) // сравнение
    {
        return true; // Правда
    }
    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя!");
        return false; // ложь
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

if (TestArray(matrix)) // Если тест проходим
{
    TransArray(matrix); // То печатаем
    Print2DArray(matrix); //
}
