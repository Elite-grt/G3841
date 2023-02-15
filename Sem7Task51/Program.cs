// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.


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


// Метод для нахождения суммы эмементов по главной диаганали
int DiagSum(int[,] arr) // Создаем массив
{
    int res = 0; // Первичный результат равен 0 
    // минимальный размер(min)= если кол-во строк>кол-ва столбцов, то тогда возращем кол-во столбцов, иначе кол-во строк
    int min = arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0); // тернарный оператор

   for (int i = 0; i < min; i=i+1) // Идем по i-му элементу 
    {
        res = res + arr[i, i]; // Все накапливаем
    } 
    return res;
}

Console.WriteLine(); // Создаем пустую строчку
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen); // Генерируем массив
Print2DArr(matrix); // Просмотр сгенерированного массива
int sumOfDiagonal = DiagSum(matrix); // Получаем резульат
Console.WriteLine("Cумма элементов по главной диагонали равна:" + sumOfDiagonal); // Просморт результата