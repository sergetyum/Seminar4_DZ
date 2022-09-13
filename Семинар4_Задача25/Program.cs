// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A:");
int number = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число B:");
int stepen = int.Parse (Console.ReadLine());
Console.Write($"А в степени В = {Math.Pow (number, stepen)}");