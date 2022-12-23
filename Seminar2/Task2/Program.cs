//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает,что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(number);
int numDigit = numStr.Length;
if (numDigit > 2) 
    Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else 
    Console.WriteLine("Третьей цифры нет");