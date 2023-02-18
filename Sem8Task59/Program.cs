// Задача №59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

// Метод нахожднния минимального элемента
(int x, int y) SearchMinElem(int[,] matr) // из метода возращаем два элемента x y
{
    int raw = 0; // переменнная которая заполнит x
    int col = 0; // переменнная которая заполнит y
    int minElem = int.MaxValue; // значение мин значения
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j])
            {
                raw = i; // координата минэлемента
                col = j; // координата минэлемента
                minElem = matr[i, j]; // заполняем эти значения в матрицу
            }
        }
    }
    return (raw, col); //выводим эти значения в матрицу
}


int[,] Update2DArray(int[,] matr, int x, int y) //выводит массив принимает матрицу и ее координаты
{
    int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1]; // Создаем новую матрицу. По горизонтали и по столбам минус один
                    //int[,] raw = arr.Getlen(0)-1;
                     //int[,] coi = arr.Getlen(1)-1;
    int k = 0;  //итератор по столбам
    int m = 0; // итератор по строчкам

    for (int i = 0; i < matr.GetLength(0); i++) // проходим родительскуя матрицу
    {
        m = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != x && j != y)  // Блокируем: условия, что можем вносить изменения  только есле не находимся на пересесечемии с мин значением
            {
                resArr[k, m] = matr[i, j];
            }
            if (j != y) // если j не равно y
            {
                m++;  // то тогда m увеличиваем
            }
        }
        if (i != x) // если i  не равно x
        {
            k++;    // то тогда k увеличиваем
        }
    }
    return resArr;
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

(int x, int y) minElem = SearchMinElem(matrix); // находим мин элемент и передаем ее в нашу матрицу

int[,] newMatrix = Update2DArray(matrix, minElem.x, minElem.y); // новая матрица в которую мы передовали исходную матрицу и передаем мин эмелет по x y
Print2DArray(newMatrix); // печатаем новую матрицу