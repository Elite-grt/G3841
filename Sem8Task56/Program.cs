// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
//  1 строка

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

// int indexLine = 0;
// // Метод для расчета строчки с мин суммой элементов
(int x, int y) MinSum2DArr(int[,] matrix)
{
    int min = int.MaxValue; // формируем переменную min
    int buf = 0;
    int indexLine = 0;
        for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        // int buf = matrix[i,0];
        for (int j = 0; j < matrix.GetLength(1); j++ )
    {
        buf += matrix[i,j]; // накапливаем значения
    }
    
    if (buf < min) 
    {
        min = buf;
        indexLine = i+1 ;
    }
    buf = 0;
    }
    return (min , indexLine);
}


// int indexLine = 0;
int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
// генерируем матрицу:
int[,] matrix = Gen2DArray(m, n, -10, 10);
Print2DArray(matrix); // выводим сгенерированную матрицу:
(int x, int y) elemMin = MinSum2DArr(matrix); // минимальная сумма в строчке
Console.WriteLine($"Строка: " + elemMin.y); // Вывод 
Console.WriteLine("Сумма: " + elemMin.x); // выводим минимальную сумму. Вывод способ 2
