// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.


// // Как писали в 2005 (последовательность решения)
// Console.WriteLine("Введите количество строк матрицы");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы");
// int m = int.Parse(Console.ReadLine());;
// System.Random numberSyntezator = new System.Random();
// int i = 0; int j = 0; // ввод переменных
// int[,] outArray = new int[n, m]  // Создаем массив с n - строками и m - столбцов

// while (i < n) // идем по строкам
// {
//     j = 0;
//     while(j < m)  // идем по столбцам
//     {
//         outArray[i, j] = numberSyntezator.Next(0, 100);
//         j++;
//     }
//     i++;
// }

// i = 0; j = 0; // Вводим переменные. Так как они объявлены выше, указываем без int

// // Печать массива
// while (i < n)
// {
//  j = 0;
//     while(j < m)  // идем по столбцам
//     {
//         Console.Write(outArray[i, j] + ""); // Заполняем строчку
//         j++;
//     }
//     i++;   
//     Console.WriteLine(); // как закончится строка переходим на новый столбец
// }



// // Структурное програмирование  (современый програмист)

// // 1) Получение данных от пользователя
// Console.WriteLine("Количество строк матрицы");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Количество строк матрицы");
// int m = int.Parse(Console.ReadLine());;
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Количество строк матрицы");
// int m = int.Parse(Console.ReadLine());;

// int m = InputNum("Количество строк матрицы");
// int n = InputNum("Количество строк матрицы");

// // 2) Генерация двухмерного массива
// int[,] matrix = FillTwoDimArray(n,m);

// // 3) Печатаем двухмерный массив
// PrintTwoDimArray(matrix);


// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.


ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы ");
int m = InputNum("Количество строк матрицы ");

//2) Генерация двумерного массива
int[,] matix = FillTwoDimArray(n,m);

//3) Печатаем двумерный массив
PrintTwoDimArray(matix);

// Метод введения данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
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