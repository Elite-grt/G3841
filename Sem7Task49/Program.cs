// Задача №49
// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

// Метод возведения в двадрат элеменов массива с четными индексами
void Update2DArr(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            //arr[i, j]*=arr[i, j] ;  // Вариант 1
            //arr[i, j]=arr[i, j]*arr[i, j];  // Вариант 2
            arr[i, j]=(int)Math.Pow(arr[i, j],2); // Вариант 3.   (arr[i, j],2) - Возводим элемент в квадрат
        }
    } 
}



int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen); // Генерируем массив
Print2DArr(matrix); // Просмотр сгенерированного массива
Update2DArr(matrix); // Генерируем новый массив
Console.WriteLine(); // Создаем пустую строчку
Print2DArr(matrix); // Просморт нового массива