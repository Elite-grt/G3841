//Задача №30
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для генерация одномерного массива 
int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random(); // генератор рандом
    int[] arr = new int[num]; // указываем длину массива
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end); // обращаемся к каждому элементу масива
    }
    return arr;
}

// Метод жля печати одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("["); // Указваем [ скобочку в начале
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]"); // Указываем в конце последний элемент массива без запятой (arr.Length-1) и добавляем ] скобку
}

int arrLen = ReadData("Введите длину массива."); // узнам длиину массива

int[] arr = Gen1DArr(arrLen, 0, 2);

Print1DArr(arr);


