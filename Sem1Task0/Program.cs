// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя). 

//Считаем данные с консоли 
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inputNum!=null)
{

      //Парсим введенное число
      //int namber = int.Parse(inputNum);
      //Находим квадрат числа
      //int result = namber*namber;
      //int result = (int)Math.Pow(namber,2);
      
      //Выводим данные в консоле
      //Console.WriteLine(result);
    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}
