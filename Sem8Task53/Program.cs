//Задача №53
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max) // raw - строки, coi -столбцы
{
    int[,] matr = new int[raw,col];
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

// 1 2 3
// 4 5 6
// 7 8 9
// in k = 0;
// 7 8 9
// 4 5 6
// 1 2 3

// Метод Swap меняет местами строчки
void SwapRaw2DArray(int[,] matr) 
{
    int k = 0;  // задали переменную

    for(int i =0; i<matr.GetLength(1);i++) // Идем по столцам
    {
        k=matr[0,i];  // кладем в элемент значения сверху - 0-я строчка, i-й элемент
        matr[0,i]=matr[matr.GetLength(0)-1,i]; // В полученый элемент кладем значение снизу (GetLength(0)-1), i-й элемент
        matr[matr.GetLength(0)-1,i]=k; // Востановить первую строчку
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m,n,0,100); // Генерируем массив
Print2DArray(matrix);
SwapRaw2DArray(matrix); // сгенер новый массив 
Console.WriteLine();
Print2DArray(matrix);