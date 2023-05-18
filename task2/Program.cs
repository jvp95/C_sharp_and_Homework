//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите день недели");
int weekDay = int.Parse(Console.ReadLine()!);
if(weekDay==1)
{
    Console.WriteLine("Пн");
}
else if(weekDay==2)
{
    Console.WriteLine("Вт");
}
else if(weekDay==3)
{
    Console.WriteLine("Среда");
}
else if(weekDay==4)
{
    Console.WriteLine("Чт");
}
else if(weekDay==5)
{
    Console.WriteLine("Пятница");
}
else if(weekDay==6)
{
    Console.WriteLine("Сб");
}
else if(weekDay==7)
{
    Console.WriteLine("Вс");
}
else
{
    Console.WriteLine("Wrong number!");
}