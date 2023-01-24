// Напишите прогр, которая принимает на вход два числа, и проверяет, явл ли одно двадратом другого

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");


// if (num1*num1==num2)
// {
//     Console.WriteLine("Первое число двадрат второго");
// }

// else
// {
//     if(num2*num2==num1)
//     {
//     Console.WriteLine("Второе число двадрат первого");
//     }
//     else
//     {
//        Console.WriteLine("Не квадраты"); 
//     }
   
// }

//Вариант 2
TestSQRT(num1,num2);
TestSQRT(num2,num1);


void TestSQRT(int i, int j)
{
    if (i*i==j)
{
    Console.WriteLine("Да, число " + j +" двадрат " + i +"");
}
    else
    {
     Console.WriteLine("число " + j +" не двадрат " + i +"");   
    }
}
