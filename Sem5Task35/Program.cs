// Задача №35
// Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int ReadData(string msg)  // Для ввода элента, который хотим найти
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)  // Метод для понятия есть ли этот элемент в массиве или нет
{
    Console.WriteLine(res);
}

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len]; // Создаем массив
    for (int i = 0; i < arr.Length; i++)   // в цикле for  проходим все элементы массива
    {
        arr[i] = new Random().Next(minValue, maxValue + 1); // заполняем max min значения
    }
    return arr; // выдаем массив
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

int CountElem(int[] arr)
 { 
    int res = 0;  // Накапливаем сколько цифр будет от 10 до 99
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n>10&&n<99);
}

int[] testArr = Gen1DArray(123,0,1000);  // Сгенеруруем массив
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество элементов в отрезке [10,99] :"+count);
