// адача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Метод введения данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// // Метод создания двухмерного массива
// int[,] Gen2DArr(int xlen, int ylen)
// {
//     int[,] arr = new int[ylen, xlen];
//     for (int i = 0; i < ylen; i++)
//     {
//         for (int j = 0; j < xlen; j++)
//         {
//             arr[i, j] = j+i;
//         }
//     }
//     return arr;
// }

// Метод для заполнения двумерного массива с рандомными элементами
int[,] Gen2DArr(int xlen, int ylen)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] arr = new int[xlen, ylen];
    while (i < xlen)
    {
        j = 0;
        while (j < ylen)
        {
            arr[i, j] = numberSyntezator.Next(-50, 50);
            j++;
        }
        i++;
    }
    return arr;
}

//Печать двухмерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Метод поиска элемента в матрице

void SerchElement(int[,] arr , int elem)
{
    bool elemfind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i,j])
            {
                Console.WriteLine("Элемент " + elem + " найден " + " на пересечении строки " + i + " и столбца " + j);
                elemfind = true;
            }
        }
    }
    if (elemfind == false)
    {
        Console.WriteLine("Элемент не найден");
    }
}

Console.WriteLine(); // Создаем пустую строчку
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
Console.WriteLine(); // Создаем пустую строчку
int[,] matrix = Gen2DArr(xlen, ylen); // Генерируем массив
Print2DArr(matrix);
SerchElement(matrix,10); // Поиск числа 10
