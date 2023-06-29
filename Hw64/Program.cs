// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Clear();

int Prompt(string msg)

{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}

int number = Prompt("Введите число: ");
int i = 1;

void NaturalNumber(int number, int count)
{
    if (count >= i)
    {
        Console.Write($"{count} ");
        NaturalNumber(number, count - 1);
    }
}

NaturalNumber(i, number);