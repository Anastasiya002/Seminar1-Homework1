// Определить день недели по введенному пользователем числу\
Console.Write("Введите число и нажмите Enter: ");
int numberDay = int.Parse(Console.ReadLine());

if (numberDay == 1) 
{
    Console.Write($"{numberDay} -> Понедельник");
}
else if (numberDay == 2)
{
    Console.Write($"{numberDay} -> Вторник");
}
else if (numberDay == 3)
{
    Console.Write($"{numberDay} -> Среда");
}
else if (numberDay == 4)
{
    Console.Write($"{numberDay} -> Четверг");
}
else if (numberDay == 5)
{
    Console.Write($"{numberDay} -> Пятница");
}
else if (numberDay == 6)
{
    Console.Write($"{numberDay} -> Суббота");
}
else if (numberDay == 7)
{
    Console.Write($"{numberDay} -> Воскресенье");
}
else
{
    Console.Write("Введено неверное значение");
}