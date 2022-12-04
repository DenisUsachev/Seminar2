/*
Напишите программу, которая выводит случаной число из отрезка [10 , 99]
и показывает наибольшую цифру числа.
*/


//Возвращает рандомное число из отрезка [left, right]
int GetRandomNumber(int left, int right)
{
    Random rnd = new Random();
    int number = rnd.Next(left,right + 1); //[left, right]
    return number;
}

// Возвращает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);

Console.WriteLine($"Сгенерировать число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Наибольшая цифрв числа: {maxDigit}");
