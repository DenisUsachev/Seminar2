/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if ((number * number == number1) || (number1 * number1 == number))
    Console.WriteLine($"Да");
else Console.WriteLine($"Число {number} не является квадратом числа {number1}");
