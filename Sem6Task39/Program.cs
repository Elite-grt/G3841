// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

// Метод учителя

int[] arr = GenArray(20,1,100);
Console.WriteLine("Исходны массив");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Нивый массив перевернутый SwapNewArray методом");
Print1DArr(copyArr);
Console.WriteLine("Исходны массив");
Print1DArr(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Исходны массив");
Print1DArr(arr);
Console.WriteLine("Исходный массив перевернутый SwapArray методом");
Print1DArr(copyArrTwo);

// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for(int i =0;i<arr.Length/2;i++)
    {
        bufElement = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i =0;i<arr.Length;i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}



// Метод студентов


// //Метод генерирует массив
// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     Random gen = new Random();
//     for(int i =0; i<len; i++)
//     {
//         arr[i]= gen.Next(minValue , maxValue);
//     }
//     return arr;
// }

// //Метод переворачивает массив
// void ReverseArray(int[] arr)
// {
//     for(int i=0; i<arr.Length/2; i++)
//     {
//         (arr[i],arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
//         // int temporary=arr[i];
//         // arr[i]=arr[arr.Length-1-i];
//         // arr[arr.Length-1-i]=temporary;
//     }
// }

// //Метод выводит на экран массив
// void Print1DArray(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// // Ввод данных массива
// int InputNum(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Создание массива
// // Вариант, если сами прописываем длину массива и его мин и мак число
// // int[] arr=Gen1DArray(10,0,10); 

// // Вариант, если хотим, что бы пользователь сам вводил параметры
// int[] arr = Gen1DArray(
//     InputNum("Введите длину массива: "),
//     InputNum("Введите минимальное число массива: "),
//     InputNum("Введите максимальное число массива: ")

// );


// Print1DArray(arr);
// ReverseArray(arr);
// Print1DArray(arr);