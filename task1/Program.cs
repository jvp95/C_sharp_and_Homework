Console.WriteLine("Является ли число 1 квадратом числа 2");
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine()!);
int result = number2 * number2;
if (result == number1)
{
Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}    
