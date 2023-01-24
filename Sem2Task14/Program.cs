// Напишите программу, где нужно ввести одно число, и проверить, кратно ли это число 7 и 23

// int num = int.Parse(Console.ReadLine()??"0");

// int res1 = num%7;
// int res2 = num%23;

// // Логическое "и" обозначается "&&"
// if((res1==0) && (res2==0))
// {
//     Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Не кратно 7 и 23");
// }

// ВАриант 2

int num = int.Parse(Console.ReadLine() ?? "0");
if ((num%7==0)&&(num%23==0)){
    Console.WriteLine("кратное");
}else{
    Console.WriteLine("не кратное 7и и 23ём");
}