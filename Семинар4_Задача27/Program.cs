// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine());
number = Math.Abs (number); 
int summa = 0;
while (number > 0)
{
    summa += number % 10; // summa = summa + number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе равна: {summa}");