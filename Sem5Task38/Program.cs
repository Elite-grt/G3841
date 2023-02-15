// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Gen1DArray(int len, int minValue, int maxValue)  // Генерируем вещественные числа (с плавающей запятой (double))
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

double MinMax( double[] arr) // Метод нахождения max и min значение элемента массива
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
    return (max - min);
}

double[] testArr = Gen1DArray(10,0,100); // Буферная переменная, куда кладется массив
Print1DArr(testArr);
double convArr = MinMax(testArr);
Console.WriteLine(convArr);
