//Напишите программу, которая выводит случайное трех значное число и удаляет вторую цифру этого числа.  
// System.Random numSintezater = new System.Random();
// int num = numSintezater.Next(100,1000);
// Console.WriteLine(num);
// int digitFirst = num/100;
// int digitLast = num%10;
// Console.WriteLine(digitFirst*10 + digitLast);


// Вариант 2

System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);
