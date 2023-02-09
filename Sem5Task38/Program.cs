// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int ReadData(string msg) // Для ввода элента, который хотим найти
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res) // Метод для понятия есть ли этот элемент в массиве или нет
// {
//     Console.WriteLine(res);
// }

// double[] Gen1DArr(int nam, int begin, int end)
// {
//     Random rnd = new Random();
//     double[] arr = new double[nam]; // Создаем массив
//     for (int i = 0; i < arr.Length; i++)   // в цикле for  проходим все элементы массива
//     {
//         arr[i] = rnd.Next(begin, end) + rnd.NextDouble(); // заполняем max и min значения
//     }
//     return arr; // выдаем массив
// }

// void Print1DArr( double[] arr) // Метод печатания массива. Принимает инвертирование массива
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++) // Пробегает по массиву
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]+"]");
// }

// double MinMax( double[] arr) // Метод нахождения max и min значение элемента и их разницу
// {
//     double max = double.MinValue;
//     double min = double.MaxValue;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//     }
//     return (max = min);
// }

// double nam = ReadData("Введите длину массива.");
// double begin = ReadData("Введите начало массива.");
// double end = ReadData("Введите конец массива.");
// double[] testArr = Gen1DArr((int)nam, (int) begin,(int)end);
// Print1DArr(testArr);
// double count = MinMax(testArr);
// Print1DArr("Разница между max и min значениями массива равна:" + count);


double[] Gen1DArray(int len, int minValue, int maxValue)  // Генерируем вещественные числа
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); // Прибавляем к целой части дробную
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double minMax( double[] arr) // Метод нахождения max и min значение элемента массива
{
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        };
    }
    return (max = min);
}

double[] testArr = Gen1DArray(10,0,100); // Буферная переменная, куда кладется массив
Print1DArr(testArr);
double convArr = minMax(testArr);
Console.WriteLine(convArr);
