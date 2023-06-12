// Задача 18: Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).


int num = Prompt("Введите номер четверти:");

int Prompt(string message)
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}
ShowQuater(num);

void FindCoordinate(int num)
{
    if (num == 1)
    {
        Console.WriteLine("I четверть X>0  Y>0");
    }
    if (num == 2)
    {
        Console.WriteLine("II четверть X<0  Y>0");
    }
    if (num == 3)
    {
        Console.WriteLine("III четверть X<0 Y<0");
    }
    if (num == 4)
    {
        Console.WriteLine("IV четверть X>0  Y<0}");
    }
}
void ShowQuater(int num)
{
if (num < 1 || num > 4)
{
    Console.WriteLine("Введена неправильная четверть");
}
else
{
    FindCoordinate(num);
}
}