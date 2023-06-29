// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N. 
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
    if (count <= number)
    {
        Console.Write($"{count} ");
        NaturalNumber(number, count + 1);
    }
}

NaturalNumber(number, i);




// Console.Clear();

// int number = Prompt("Введите число: ");
// Console.WriteLine(PrintNumber(number));

// int Prompt(string message)
// {
// Console.Write(message);
// int number = int.Parse(Console.ReadLine()!);
// return number;
// }

// string PrintNumber(int number)
// {
// if (number == 1) return "1";

// return $"{PrintNumber(number - 1)} {number}";
// }
