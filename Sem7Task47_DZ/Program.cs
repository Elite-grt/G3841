// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");

//2) Генерация двумерного массива
double[,] matrix = Gen2DArray(n, m);

//3) Печатаем двумерный массив
Print2DArray(matrix);

// Метод введения данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации матрици с дробными случайными числами
double[,] Gen2DArray(int m, int n)
{
    double[,] matrix = new double[n, m];
    Random rnd = new Random(); // инициализируем генератор случайных чисел
    int i = 0; // счетчики для цикла
    int j = 0;

    while (i < n)
    {
        while (j < m)
        {
            // записываем в массив случайные числа 
            matrix[i, j] = new Random().Next(-99, 99) / 10.0;
            j++;
        }
        j = 0;
        i++;
    }
    return matrix; // возвращаем результат
}

//метод для печати двумерного массива
void Print2DArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16)); //Рамдомня смена цвета
                                     //col[new System.Random().Next(0,16)]; 
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}