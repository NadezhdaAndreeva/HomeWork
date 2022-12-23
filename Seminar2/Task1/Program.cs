// Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());
for (int i = 1; number < 100 | number > 999; i++)
{
  Console.WriteLine(i + "Число не трехзначное. Введите еще раз трехзначное число:");
    number = int.Parse(Console.ReadLine());
}
number = number / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа: {number}");
