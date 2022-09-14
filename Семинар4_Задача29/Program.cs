// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и 
// распечатайте.

// Вариант 1.
// Создаем массив из 8 элементов, заполняем его пользователем и выводим в терминал.
// int[] array = new int[8];
// Console.WriteLine("Введите 8 чисел:");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите a[{i}]: ");
//     array[i] = int.Parse(Console.ReadLine()); 
// }
// string yourarray = string.Join(", ", array);
// Console.WriteLine($"Ваш массив: [{yourarray}]");


// Вариант 2. (Как в примере ответа 8 чисел вводим двумя строками)
// Пользователь вводит числа, из них формируем массив.
Console.WriteLine("Введите через запятую 8 чисел, пять в первой строке и три во второй:");
string numbers = Console.ReadLine ();
string[] array1 = numbers.Split (' ');

string numbers1 = Console.ReadLine ();
string[] array2 = numbers1.Split (' ');


string yourarray1 = string.Join(", ", array1);
Console.WriteLine($"[{yourarray1}]");
string yourarray2 = string.Join(", ", array2);
Console.WriteLine($"[{yourarray2}]");