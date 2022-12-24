//Напишите программу, которая принимает на вход пятизначное число и
//проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (9999 < num | 100000 > num)
{
    int num2 = 0;
    while (9999 < num | 100000 > num)
    {
        num2 = num2 * 10;
        num2 = num2 + num % 10;
    }
    if (num == num2)
        Console.WriteLine("Это полиндром");
    else
        Console.WriteLine("Это не полиндром");
}
else Console.WriteLine("Значение не пятизначное");