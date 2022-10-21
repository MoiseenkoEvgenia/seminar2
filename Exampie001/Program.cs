// Напишите программу которая принимает число и показывает последнюю цифру этого числа
int GetLastDigit(int number)
{
    return number % 10;
}

int testNumber = 5123890;

Console.WriteLine(GetLastDigit(testNumber));
