//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число и нажмите Enter: ");
int numberN = int.Parse(Console.ReadLine());

int somenumber = 1;

Console.Write($"{numberN} -> ");

while (somenumber <=numberN)
{
    if (somenumber%2 ==0)
    {
        Console.Write($"{somenumber} ");
    }
    somenumber = somenumber + 1;
}

