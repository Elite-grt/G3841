// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
//  чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


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

int[] numbers = Gen1DArray(12, -9, 9); // Сгенеруруем массив

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}


Print1DArr(numbers); // Напетаем этот массив
Console.WriteLine($"Число элементов больше нуля: {sum}");