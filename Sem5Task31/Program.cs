// // Задача №31
// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.

int posetivSum=0; //объявлем переменную
int negotivSum=0;

int[] testArr = Gen1DArr(12,-9,9); //Вызываем
NegPosSum(testArr); //Посчитаем сколько полож и отрицательных
Print1DArr(testArr); //Напечатаем

PrintData("Сумма положительных чисел в массиве: ", posetivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negotivSum);

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len]; // Создаем массив
    for (int i = 0; i < arr.Length; i++)   // в цикле for  проходим все элементы массива
    {
        arr[i] = new Random().Next(minValue, maxValue + 1); // заполняем max min значения
    }
    return arr; // выдаем массив
}

void Print1DArr(int[] arr) // Метод печатания массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) // заполняем все кроме последнего
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

void NegPosSum(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]>0) // Если элемент массива больше 0
        {
            posetivSum+=arr[i];
        }
        else //Иначе
        {
            negotivSum+=arr[i];
        }

    }
}


// Пример Савелия
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int len = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// Random rnd = new Random();
// int[] createArray(int len)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void showArray(int[] arr)
// {
//     for (int i = 0; i < len; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[]arr=createArray(len);
// showArray(arr);
// int Sum(int[] arr, bool MinOrMax){
//     int sum=0;
//     foreach(var i in arr){
//         if ((MinOrMax==false)&&(i<0)){
//             sum+=i;
//         }
//         if ((MinOrMax==true)&&(i>0)){
//             sum+=i;
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Позитивные "+Sum(arr,true));
// Console.WriteLine("Негативные "+Sum(arr,false));
