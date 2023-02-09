// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SunPos(int[] arr)
 { 
    int res = 0;  // Накапливаем сколько цифр будет от 100 до 999
    for (int i = 1; i < arr.Length; i = i+2)
    {
        res += arr[i];
    }
    return res;
}

int[] testArr = Gen1DArray(7,1,99);  // Сгенеруруем массив
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Cумму элементов, стоящих на нечётных позициях :"+count);
