// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число и нажмите Enter: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите второе число и нажмите Enter: ");
int numberTwo = int.Parse(Console.ReadLine());


if (numberOne > numberTwo)
{
    Console.Write($"max = {numberOne}");
}
else
{
     Console.Write($"max = {numberTwo}");
}