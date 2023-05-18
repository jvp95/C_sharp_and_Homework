// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = number1 * -1;
int temp;
if (number1 < 0)
{
    temp = number1;
    number1 = number2;
    number2 = temp;
}
while (number2 <= number1)
{
    Console.WriteLine(number2 + "");
    number2 += 1;
}