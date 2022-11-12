// Проверка, является ли первое число квадратом второго
Console.Write("Введите первое число и нажмите Enter: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите второе число и нажмите Enter: ");
int numberTwo = int.Parse(Console.ReadLine());

int numberSqr = numberTwo*numberTwo;
if (numberSqr == numberOne) 
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число НЕ является квадратом второго");
}