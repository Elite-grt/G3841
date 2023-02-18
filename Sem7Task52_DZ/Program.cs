// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод введения данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод создания двухмерного массива
int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

// // Метод для заполнения двумерного массива с рандомными элементами
// int[,] Gen2DArr(int xlen, int ylen)
// {
//     System.Random numberSyntezator = new System.Random();
//     int i = 0; int j = 0;
//     int[,] arr = new int[xlen, ylen];
//     while (i < xlen)
//     {
//         j = 0;
//         while (j < ylen)
//         {
//             arr[i, j] = numberSyntezator.Next(-50, 50);
//             j++;
//         }
//         i++;
//     }
//     return arr;
// }

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



// // Метод для поиска среднеарифметического значения по строке

// int[] MeanColum (int[,] arr)
// {
//     int[] means = new int[arr.GetLength(0)];
//     for(int i = 0; i < arr.GetLength(0); i++) // проходим по строкам (0)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++) // проходим по столбцам (1)
//         {
//             means[i] += arr[i,j]; // накапливаем сумму в means 
//         }
//         means [i] = means[i]/arr.GetLength(1); // Делим сумму means на количество столбцов
//     }
//     return means;
// }

// void Print1DArr(int[] arr) // Метод печатания массива. Принимает инвертирование массива
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++) // Пробегает по массиву
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]+"]");
// }    


// Метод для поиска среднеарифметического значения по столбцам

int[] MeanColum (int[,] arr)
{
    int[] means = new int[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(1); i++) // проходим по столбцам (1)
    {
        for(int j = 0; j < arr.GetLength(0); j++) // проходим по строкам (0)
        {
            means[i] += arr[j,i]; // накапливаем сумму в means 
        }
        means [i] = means[i]/arr.GetLength(0); // Делим сумму means на количество строк
    }
    return means;
}

void Print1DArr(int[] arr) // Метод печатания массива. Принимает инвертирование массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) // Пробегает по массиву
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}    

Console.WriteLine(); // Создаем пустую строчку
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
Console.WriteLine(); // Создаем пустую строчку
int[,] matrix = Gen2DArr(xlen, ylen); // Генерируем 2х мерный массив
Print2DArr(matrix);
int[] meansColums = MeanColum(matrix); // Генерируем среднеарифметическое значение
Print1DArr(meansColums); // 
