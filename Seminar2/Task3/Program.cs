// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру дня недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if(numberDay >= 1 && numberDay <= 7)
{
    if (numberDay == 6 || numberDay == 7)
    Console.WriteLine("Ура!Выходной");
    else
    Console.WriteLine("Это рабочий день");
}
else
Console.WriteLine("В неделе семь дней");
