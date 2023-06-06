// 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8



int FindFirstDigit(int num)
{
    int firstNumber = num / 10; // деление нацело 78=7
    return firstNumber;
}
int FindSecondDigit(int num)
{
    int secondNumber = num % 10; // вычисление последней цифры 78=8
    return secondNumber;
}

void FindLargestDigit(int num, int firstNumber, int secondNumber)
{
    Console.WriteLine("Рандомное число: " + num);
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первая цифра больше второй");
    }
    else if (secondNumber > firstNumber)
    {
        Console.WriteLine("Вторая цифра больше второй");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}
int number = new Random().Next(10, 100);
int firstDigit = FindFirstDigit(number);
int secondDigit = FindSecondDigit(number);
FindLargestDigit(number, firstDigit, secondDigit);

int number1 = new Random().Next(100);
int firstDigit1 = FindFirstDigit(number1);
int secondDigit1 = FindSecondDigit(number1);
FindLargestDigit(number1, firstDigit1, secondDigit1);

int number2 = new Random().Next(-80, 10);
int firstDigit2 = FindFirstDigit(number2);
int secondDigit2 = FindSecondDigit(number2);
FindLargestDigit(number2, firstDigit2, secondDigit2);


// FindLargestDigit(number);