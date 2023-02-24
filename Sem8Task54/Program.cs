// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


// Метод пузырька
static int[] BubbleSort(int[] bufA)
        {
            int temp;
            for (int i = 0; i < bufA.Length; i++)
            {
                for (int j = i + 1; j < bufA.Length; j++)
                {
                    if (bufA[i] > bufA[j])
                    {
                        temp = bufA[i];
                        bufA[i] = bufA[j];
                        bufA[j] = temp;
                    }                   
                }            
            }
            return bufA;
        }

// Метод сортировки массива
void Sort2DArr(int [,]arr) 
{
    int[] bufA = new int[arr.GetLength(1)]; // берем буфкрный массив (одномерный)
    for (int i = 0; i < arr.GetLength(0); i++) // заходим на строчку
    {

        for (int j = 0; j <arr.GetLength(0); j++)
        {
            bufA[j] = arr[i,j];
        }
         BubbleSort (bufA);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = bufA[j];
        }
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
// генерируем матрицу:
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix); // выводим сгенерированную матрицу:
Sort2DArr(matrix); // сортируем матрицу по строкам
Print2DArray(matrix); // и выводим ее