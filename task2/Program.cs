/*Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int GetRandomNumber()
{
    return new Random().Next(100, 1000);
}


void ShowRandomNumber(int number)
{
    Console.WriteLine($"Случайной трёхзначное число: {number}");
    int result = (((number / 100) * 10 ) + (number % 10));
    Console.WriteLine(result);
}

ShowRandomNumber(GetRandomNumber());