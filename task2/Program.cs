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