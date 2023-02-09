// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве.

int ReadData(string msg) // Для ввода элента, который хотим найти
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res) // Метод для понятия есть ли этот элемент в массиве или нет
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

int Search(int[] arr, int e)  // Метод для ответа есть ли этот элемент в массиве или нет. Передаем внутрь сам массив и тот элемент который ищем
{
    int res = -1; // Присвоили -1. Если при поиске выдает -1 значит число не нашли
    for (int i = 0; i < arr.Length; i++) // Проходим по массиву
    {
        if (arr[i] == e) // если элемент равен тому который введен
        {
            res = i; // если находим, сохраняем ондекс в переменной res
            break; // Остановка после нахождения первого элемента выход из цикла for
        }
    }
    return res; // Выдаем его на выход
}

int[] testArr = Gen1DArray(12, -9, 9); // Сгенеруруем массив
Print1DArr(testArr); // Напетаем этот массив
int element = ReadData("Какой элемент найти?: ");
int result = Search(testArr, element); // В результате ыдаем массив и элемент 

if (result >= 0) // Если
{
    PrintData("Элемент найден в позиции: " + (result+1));
}
else
{
    PrintData("В массиве элемент не найден!");
}

// Random rnd = new Random();
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int[] create1DArray(int len, int num1, int num2)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void show1DArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[] invert1DArray(int[] array)
// {
//     int[] arr=new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         arr[i]=array[i]*-1;
//     }
//     return arr;
// }
// int len = InputNum("Введите длинну массива: ");
// int x = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// int[]arr=create1DArray(len,num1,num2);
// int[] searchXIn1DArray(int x, int[] arr){
//     int[] indexs={};
//     for(int i=0; i<arr.Lengt
